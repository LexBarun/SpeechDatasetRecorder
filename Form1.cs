using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace SpeechDatasetRecorder
{
    public partial class Form1 : Form
    {
        private int lineNum;
        private WaveIn waveSource = null;
        private WaveFileWriter waveFile = null;
        private WaveOutEvent playRecord;
        private AudioFileReader audioFile;

        public Form1()
        {
            InitializeComponent();
            buttonReplay.Enabled = false;
            buttonStopRec.Enabled = false;
            buttonNext.Enabled = false;
        }

        private void buttonLoadTranscript_Click(object sender, EventArgs e)
        {
            dialogFileTranscriptPath.Filter = "Text File|*.txt";
            if(dialogFileTranscriptPath.ShowDialog() == DialogResult.OK)
            {
                textBoxTranscriptPath.Text = dialogFileTranscriptPath.FileName;
                using (StreamReader file = new StreamReader(textBoxTranscriptPath.Text))
                {
                    for (int i = 0; i < 1; i++)
                    {
                        richTextBoxTranscript.Text = file.ReadLine();
                    }
                }
            }
        }

        public void buttonSavePath_Click(object sender, EventArgs e)
        {
            if(dialogFolderSavePath.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = dialogFolderSavePath.SelectedPath;
                if (!File.Exists(@textBoxSavePath.Text + @"\checkpoint.txt"))
                {
                    using (TextWriter newCheck = new StreamWriter(@textBoxSavePath.Text + @"\checkpoint.txt"))
                    {
                        newCheck.WriteLine("0");
                        newCheck.Close();
                    }
                }
                using (StreamReader checkpoint = new StreamReader(@textBoxSavePath.Text + @"\checkpoint.txt"))
                {
                    int.TryParse(checkpoint.ReadLine(), out lineNum);
                }
                using (StreamReader transcript = new StreamReader(@textBoxTranscriptPath.Text))
                {
                    for (int i = 0; i <= lineNum; i++)
                    {
                        richTextBoxTranscript.Text = transcript.ReadLine();
                    }
                }
                Directory.CreateDirectory(@textBoxSavePath.Text + @"\clips");
            }
        }

        private void buttonRec_Click(object sender, EventArgs e)
        {
            buttonRec.Enabled = false;
            buttonReplay.Enabled = false;
            buttonNext.Enabled = false;
            buttonStopRec.Enabled = true;

            //Arigathanks gozaimuch Corey (https://stackoverflow.com/a/17983876/15597379)
            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(16000, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            waveFile = new WaveFileWriter(@textBoxSavePath.Text + @"\clips\Test.wav", waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        private void buttonStopRec_Click(object sender, EventArgs e)
        {
            buttonRec.Enabled = true;
            buttonReplay.Enabled = true;
            buttonNext.Enabled = true;
            buttonStopRec.Enabled = false;
            buttonRec.Text = "Retry";
            waveSource.StopRecording();
            //stop
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

            buttonRec.Enabled = true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonRec.Enabled = true;
            buttonReplay.Enabled = false;
            buttonNext.Enabled = false;
            buttonStopRec.Enabled = false;
            buttonRec.Text = "REC";
            if(!File.Exists(@textBoxSavePath.Text + @"\main.csv"))
            {
                using (TextWriter CSV = new StreamWriter(@textBoxSavePath.Text + @"\main.csv"))
                {
                    CSV.WriteLine("wav_filename,wav_size,transcript");
                    CSV.Close();
                }
            }
            File.Move(@textBoxSavePath.Text + @"\clips\Test.wav", String.Format(@"{0}\clips\{1}.wav", @textBoxSavePath.Text, lineNum));
            using (TextWriter CSV = new StreamWriter(@textBoxSavePath.Text + @"\main.csv", true))
            {
                long fileSize = new System.IO.FileInfo(String.Format(@"{0}\clips\{1}.wav", @textBoxSavePath.Text, lineNum)).Length;
                CSV.WriteLine(String.Format("{0}.wav,{1},{2}", lineNum, fileSize, richTextBoxTranscript.Text));
                CSV.Close();
            }
            lineNum++;
            using (TextWriter checkpoint = new StreamWriter(@textBoxSavePath.Text + @"\checkpoint.txt"))
            {
                checkpoint.WriteLine(lineNum);
                checkpoint.Close();
            }
            using (StreamReader transcript = new StreamReader(@textBoxTranscriptPath.Text))
            {
                for (int i = 0; i <= lineNum; i++)
                {
                    richTextBoxTranscript.Text = transcript.ReadLine();
                }
            }
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            buttonRec.Enabled = false;
            buttonReplay.Enabled = false;
            buttonNext.Enabled = false;
            buttonStopRec.Enabled = false;
            buttonRec.Text = "Retry";
            
            if (playRecord == null)
            {
                playRecord = new WaveOutEvent();
                playRecord.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@textBoxSavePath.Text + @"\clips\Test.wav");
                playRecord.Init(audioFile);
            }
            playRecord.Play();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            playRecord.Dispose();
            playRecord = null;
            audioFile.Dispose();
            audioFile = null;
            buttonRec.Enabled = true;
            buttonReplay.Enabled = true;
            buttonNext.Enabled = true;
            buttonStopRec.Enabled = true;
        }
    }
}
