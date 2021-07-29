
namespace SpeechDatasetRecorder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadTranscript = new System.Windows.Forms.Button();
            this.textBoxTranscriptPath = new System.Windows.Forms.TextBox();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonSavePath = new System.Windows.Forms.Button();
            this.richTextBoxTranscript = new System.Windows.Forms.RichTextBox();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.dialogFolderSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.dialogFileTranscriptPath = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonLoadTranscript
            // 
            this.buttonLoadTranscript.Location = new System.Drawing.Point(309, 13);
            this.buttonLoadTranscript.Name = "buttonLoadTranscript";
            this.buttonLoadTranscript.Size = new System.Drawing.Size(125, 23);
            this.buttonLoadTranscript.TabIndex = 0;
            this.buttonLoadTranscript.Text = "Load Transcript File...";
            this.buttonLoadTranscript.UseVisualStyleBackColor = true;
            this.buttonLoadTranscript.Click += new System.EventHandler(this.buttonLoadTranscript_Click);
            // 
            // textBoxTranscriptPath
            // 
            this.textBoxTranscriptPath.Location = new System.Drawing.Point(13, 13);
            this.textBoxTranscriptPath.Name = "textBoxTranscriptPath";
            this.textBoxTranscriptPath.ReadOnly = true;
            this.textBoxTranscriptPath.Size = new System.Drawing.Size(290, 23);
            this.textBoxTranscriptPath.TabIndex = 1;
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(13, 42);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.ReadOnly = true;
            this.textBoxSavePath.Size = new System.Drawing.Size(290, 23);
            this.textBoxSavePath.TabIndex = 3;
            // 
            // buttonSavePath
            // 
            this.buttonSavePath.Location = new System.Drawing.Point(309, 42);
            this.buttonSavePath.Name = "buttonSavePath";
            this.buttonSavePath.Size = new System.Drawing.Size(125, 23);
            this.buttonSavePath.TabIndex = 2;
            this.buttonSavePath.Text = "Save Path...";
            this.buttonSavePath.UseVisualStyleBackColor = true;
            this.buttonSavePath.Click += new System.EventHandler(this.buttonSavePath_Click);
            // 
            // richTextBoxTranscript
            // 
            this.richTextBoxTranscript.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxTranscript.Location = new System.Drawing.Point(13, 71);
            this.richTextBoxTranscript.Name = "richTextBoxTranscript";
            this.richTextBoxTranscript.ReadOnly = true;
            this.richTextBoxTranscript.Size = new System.Drawing.Size(421, 138);
            this.richTextBoxTranscript.TabIndex = 4;
            this.richTextBoxTranscript.Text = "lorem ipsum";
            // 
            // buttonRec
            // 
            this.buttonRec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRec.ForeColor = System.Drawing.Color.Red;
            this.buttonRec.Location = new System.Drawing.Point(188, 216);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(75, 34);
            this.buttonRec.TabIndex = 5;
            this.buttonRec.Text = "REC";
            this.buttonRec.UseVisualStyleBackColor = true;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonStopRec
            // 
            this.buttonStopRec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStopRec.Location = new System.Drawing.Point(188, 256);
            this.buttonStopRec.Name = "buttonStopRec";
            this.buttonStopRec.Size = new System.Drawing.Size(75, 34);
            this.buttonStopRec.TabIndex = 6;
            this.buttonStopRec.Text = "STOP";
            this.buttonStopRec.UseVisualStyleBackColor = true;
            this.buttonStopRec.Click += new System.EventHandler(this.buttonStopRec_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(269, 215);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 37);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonReplay
            // 
            this.buttonReplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReplay.Location = new System.Drawing.Point(107, 215);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(75, 37);
            this.buttonReplay.TabIndex = 9;
            this.buttonReplay.Text = "REPLAY";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // dialogFolderSavePath
            // 
            this.dialogFolderSavePath.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 294);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStopRec);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.richTextBoxTranscript);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.buttonSavePath);
            this.Controls.Add(this.textBoxTranscriptPath);
            this.Controls.Add(this.buttonLoadTranscript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTranscript;
        private System.Windows.Forms.TextBox textBoxTranscriptPath;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonSavePath;
        private System.Windows.Forms.RichTextBox richTextBoxTranscript;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonStopRec;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.FolderBrowserDialog dialogFolderSavePath;
        private System.Windows.Forms.OpenFileDialog dialogFileTranscriptPath;
    }
}

