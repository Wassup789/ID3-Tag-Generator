namespace ID3_Tags_Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.its_searchQueryButton = new System.Windows.Forms.Button();
            this.its_dataSelector = new System.Windows.Forms.ComboBox();
            this.groupBox_itunesSelector = new System.Windows.Forms.GroupBox();
            this.its_dataSelectorLabel = new System.Windows.Forms.Label();
            this.its_searchQueryLabel = new System.Windows.Forms.Label();
            this.its_searchQueryInput = new System.Windows.Forms.TextBox();
            this.groupBox_id3 = new System.Windows.Forms.GroupBox();
            this.id3_dataGridView = new System.Windows.Forms.DataGridView();
            this.id3_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id3_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_albumArt = new System.Windows.Forms.GroupBox();
            this.albumArt_picture = new System.Windows.Forms.PictureBox();
            this.groupBox_file = new System.Windows.Forms.GroupBox();
            this.file_actionLabel = new System.Windows.Forms.Label();
            this.file_actionApplyButton = new System.Windows.Forms.Button();
            this.file_selectFileButton = new System.Windows.Forms.Button();
            this.file_selectFileText = new System.Windows.Forms.TextBox();
            this.file_selectFileLabel = new System.Windows.Forms.Label();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_itunesSelector.SuspendLayout();
            this.groupBox_id3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id3_dataGridView)).BeginInit();
            this.groupBox_albumArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt_picture)).BeginInit();
            this.groupBox_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // its_searchQueryButton
            // 
            this.its_searchQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.its_searchQueryButton.Location = new System.Drawing.Point(508, 17);
            this.its_searchQueryButton.Name = "its_searchQueryButton";
            this.its_searchQueryButton.Size = new System.Drawing.Size(75, 23);
            this.its_searchQueryButton.TabIndex = 2;
            this.its_searchQueryButton.Text = "Search";
            this.its_searchQueryButton.UseVisualStyleBackColor = true;
            this.its_searchQueryButton.Click += new System.EventHandler(this.its_searchQueryAction);
            // 
            // its_dataSelector
            // 
            this.its_dataSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.its_dataSelector.FormattingEnabled = true;
            this.its_dataSelector.Location = new System.Drawing.Point(87, 45);
            this.its_dataSelector.Name = "its_dataSelector";
            this.its_dataSelector.Size = new System.Drawing.Size(496, 21);
            this.its_dataSelector.TabIndex = 4;
            this.its_dataSelector.SelectedIndexChanged += new System.EventHandler(this.its_dataSelector_SelectedIndexChanged);
            // 
            // groupBox_itunesSelector
            // 
            this.groupBox_itunesSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_itunesSelector.Controls.Add(this.its_dataSelectorLabel);
            this.groupBox_itunesSelector.Controls.Add(this.its_searchQueryLabel);
            this.groupBox_itunesSelector.Controls.Add(this.its_searchQueryInput);
            this.groupBox_itunesSelector.Controls.Add(this.its_dataSelector);
            this.groupBox_itunesSelector.Controls.Add(this.its_searchQueryButton);
            this.groupBox_itunesSelector.Location = new System.Drawing.Point(12, 12);
            this.groupBox_itunesSelector.Name = "groupBox_itunesSelector";
            this.groupBox_itunesSelector.Size = new System.Drawing.Size(589, 79);
            this.groupBox_itunesSelector.TabIndex = 2;
            this.groupBox_itunesSelector.TabStop = false;
            this.groupBox_itunesSelector.Text = "iTunes Selector";
            // 
            // its_dataSelectorLabel
            // 
            this.its_dataSelectorLabel.AutoSize = true;
            this.its_dataSelectorLabel.Location = new System.Drawing.Point(6, 48);
            this.its_dataSelectorLabel.Name = "its_dataSelectorLabel";
            this.its_dataSelectorLabel.Size = new System.Drawing.Size(76, 13);
            this.its_dataSelectorLabel.TabIndex = 3;
            this.its_dataSelectorLabel.Text = "Select a track:";
            // 
            // its_searchQueryLabel
            // 
            this.its_searchQueryLabel.AutoSize = true;
            this.its_searchQueryLabel.Location = new System.Drawing.Point(6, 22);
            this.its_searchQueryLabel.Name = "its_searchQueryLabel";
            this.its_searchQueryLabel.Size = new System.Drawing.Size(73, 13);
            this.its_searchQueryLabel.TabIndex = 0;
            this.its_searchQueryLabel.Text = "Search query:";
            // 
            // its_searchQueryInput
            // 
            this.its_searchQueryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.its_searchQueryInput.Location = new System.Drawing.Point(87, 19);
            this.its_searchQueryInput.Name = "its_searchQueryInput";
            this.its_searchQueryInput.Size = new System.Drawing.Size(415, 20);
            this.its_searchQueryInput.TabIndex = 1;
            this.its_searchQueryInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.its_searchQueryKeyDown);
            // 
            // groupBox_id3
            // 
            this.groupBox_id3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_id3.Controls.Add(this.id3_dataGridView);
            this.groupBox_id3.Location = new System.Drawing.Point(159, 178);
            this.groupBox_id3.Name = "groupBox_id3";
            this.groupBox_id3.Size = new System.Drawing.Size(442, 363);
            this.groupBox_id3.TabIndex = 3;
            this.groupBox_id3.TabStop = false;
            this.groupBox_id3.Text = "ID3 Tag Editor";
            // 
            // id3_dataGridView
            // 
            this.id3_dataGridView.AllowUserToResizeRows = false;
            this.id3_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id3_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.id3_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.id3_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.id3_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id3_name,
            this.id3_value});
            this.id3_dataGridView.Location = new System.Drawing.Point(6, 19);
            this.id3_dataGridView.Name = "id3_dataGridView";
            this.id3_dataGridView.RowHeadersVisible = false;
            this.id3_dataGridView.Size = new System.Drawing.Size(430, 338);
            this.id3_dataGridView.TabIndex = 0;
            // 
            // id3_name
            // 
            this.id3_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id3_name.HeaderText = "Name";
            this.id3_name.Name = "id3_name";
            this.id3_name.Width = 60;
            // 
            // id3_value
            // 
            this.id3_value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id3_value.HeaderText = "Value";
            this.id3_value.Name = "id3_value";
            // 
            // groupBox_albumArt
            // 
            this.groupBox_albumArt.Controls.Add(this.albumArt_picture);
            this.groupBox_albumArt.Location = new System.Drawing.Point(12, 178);
            this.groupBox_albumArt.Name = "groupBox_albumArt";
            this.groupBox_albumArt.Size = new System.Drawing.Size(141, 156);
            this.groupBox_albumArt.TabIndex = 4;
            this.groupBox_albumArt.TabStop = false;
            this.groupBox_albumArt.Text = "Album Art";
            // 
            // albumArt_picture
            // 
            this.albumArt_picture.Location = new System.Drawing.Point(9, 19);
            this.albumArt_picture.Name = "albumArt_picture";
            this.albumArt_picture.Size = new System.Drawing.Size(126, 126);
            this.albumArt_picture.TabIndex = 0;
            this.albumArt_picture.TabStop = false;
            // 
            // groupBox_file
            // 
            this.groupBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_file.Controls.Add(this.file_actionLabel);
            this.groupBox_file.Controls.Add(this.file_actionApplyButton);
            this.groupBox_file.Controls.Add(this.file_selectFileButton);
            this.groupBox_file.Controls.Add(this.file_selectFileText);
            this.groupBox_file.Controls.Add(this.file_selectFileLabel);
            this.groupBox_file.Location = new System.Drawing.Point(12, 97);
            this.groupBox_file.Name = "groupBox_file";
            this.groupBox_file.Size = new System.Drawing.Size(589, 75);
            this.groupBox_file.TabIndex = 5;
            this.groupBox_file.TabStop = false;
            this.groupBox_file.Text = "File Selector";
            // 
            // file_actionLabel
            // 
            this.file_actionLabel.AutoSize = true;
            this.file_actionLabel.Location = new System.Drawing.Point(6, 50);
            this.file_actionLabel.Name = "file_actionLabel";
            this.file_actionLabel.Size = new System.Drawing.Size(40, 13);
            this.file_actionLabel.TabIndex = 4;
            this.file_actionLabel.Text = "Action:";
            // 
            // file_actionApplyButton
            // 
            this.file_actionApplyButton.Location = new System.Drawing.Point(77, 45);
            this.file_actionApplyButton.Name = "file_actionApplyButton";
            this.file_actionApplyButton.Size = new System.Drawing.Size(75, 23);
            this.file_actionApplyButton.TabIndex = 3;
            this.file_actionApplyButton.Text = "Set Tags";
            this.file_actionApplyButton.UseVisualStyleBackColor = true;
            this.file_actionApplyButton.Click += new System.EventHandler(this.file_actionApplyButton_Click);
            // 
            // file_selectFileButton
            // 
            this.file_selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.file_selectFileButton.Location = new System.Drawing.Point(508, 17);
            this.file_selectFileButton.Name = "file_selectFileButton";
            this.file_selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.file_selectFileButton.TabIndex = 2;
            this.file_selectFileButton.Text = "Open File";
            this.file_selectFileButton.UseVisualStyleBackColor = true;
            this.file_selectFileButton.Click += new System.EventHandler(this.file_selectFileButton_Click);
            // 
            // file_selectFileText
            // 
            this.file_selectFileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_selectFileText.Location = new System.Drawing.Point(77, 19);
            this.file_selectFileText.Name = "file_selectFileText";
            this.file_selectFileText.ReadOnly = true;
            this.file_selectFileText.Size = new System.Drawing.Size(425, 20);
            this.file_selectFileText.TabIndex = 1;
            this.file_selectFileText.Click += new System.EventHandler(this.file_selectFileButton_Click);
            // 
            // file_selectFileLabel
            // 
            this.file_selectFileLabel.AutoSize = true;
            this.file_selectFileLabel.Location = new System.Drawing.Point(6, 22);
            this.file_selectFileLabel.Name = "file_selectFileLabel";
            this.file_selectFileLabel.Size = new System.Drawing.Size(65, 13);
            this.file_selectFileLabel.TabIndex = 0;
            this.file_selectFileLabel.Text = "Select a file:";
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.Filter = "Audio Files|*.mp3;*.m4a;*.flac;*.aiff;*.wav|All Files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 553);
            this.Controls.Add(this.groupBox_file);
            this.Controls.Add(this.groupBox_albumArt);
            this.Controls.Add(this.groupBox_id3);
            this.Controls.Add(this.groupBox_itunesSelector);
            this.MinimumSize = new System.Drawing.Size(300, 385);
            this.Name = "MainForm";
            this.Text = "ID3 Tags Generator";
            this.groupBox_itunesSelector.ResumeLayout(false);
            this.groupBox_itunesSelector.PerformLayout();
            this.groupBox_id3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.id3_dataGridView)).EndInit();
            this.groupBox_albumArt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumArt_picture)).EndInit();
            this.groupBox_file.ResumeLayout(false);
            this.groupBox_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button its_searchQueryButton;
        private System.Windows.Forms.ComboBox its_dataSelector;
        private System.Windows.Forms.GroupBox groupBox_itunesSelector;
        private System.Windows.Forms.Label its_searchQueryLabel;
        private System.Windows.Forms.TextBox its_searchQueryInput;
        private System.Windows.Forms.Label its_dataSelectorLabel;
        private System.Windows.Forms.GroupBox groupBox_id3;
        private System.Windows.Forms.DataGridView id3_dataGridView;
        private System.Windows.Forms.GroupBox groupBox_albumArt;
        private System.Windows.Forms.PictureBox albumArt_picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn id3_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id3_value;
        private System.Windows.Forms.GroupBox groupBox_file;
        private System.Windows.Forms.Label file_actionLabel;
        private System.Windows.Forms.Button file_actionApplyButton;
        private System.Windows.Forms.Button file_selectFileButton;
        private System.Windows.Forms.TextBox file_selectFileText;
        private System.Windows.Forms.Label file_selectFileLabel;
        private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
    }
}

