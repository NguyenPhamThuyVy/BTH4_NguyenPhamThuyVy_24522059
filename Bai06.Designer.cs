namespace BTH4_BT6
{
    partial class Bai06
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnCopy = new Button();
            btnDest = new Button();
            txtDest = new TextBox();
            label2 = new Label();
            btnSource = new Button();
            txtSource = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            statusBar = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopy);
            groupBox1.Controls.Add(btnDest);
            groupBox1.Controls.Add(txtDest);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSource);
            groupBox1.Controls.Add(txtSource);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(36, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = SystemColors.AppWorkspace;
            btnCopy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.ForeColor = SystemColors.ControlText;
            btnCopy.Location = new Point(272, 192);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(223, 43);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Sao Chép";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnDest
            // 
            btnDest.BackColor = SystemColors.AppWorkspace;
            btnDest.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDest.ForeColor = SystemColors.ControlText;
            btnDest.Location = new Point(696, 124);
            btnDest.Name = "btnDest";
            btnDest.Size = new Size(53, 35);
            btnDest.TabIndex = 5;
            btnDest.Text = "...";
            btnDest.UseVisualStyleBackColor = false;
            btnDest.Click += btnDest_Click;
            // 
            // txtDest
            // 
            txtDest.Location = new Point(272, 124);
            txtDest.Multiline = true;
            txtDest.Name = "txtDest";
            txtDest.ReadOnly = true;
            txtDest.Size = new Size(418, 35);
            txtDest.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(27, 124);
            label2.Name = "label2";
            label2.Size = new Size(239, 46);
            label2.TabIndex = 3;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // btnSource
            // 
            btnSource.BackColor = SystemColors.AppWorkspace;
            btnSource.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSource.ForeColor = SystemColors.ControlText;
            btnSource.Location = new Point(696, 47);
            btnSource.Name = "btnSource";
            btnSource.Size = new Size(53, 35);
            btnSource.TabIndex = 2;
            btnSource.Text = "...";
            btnSource.UseVisualStyleBackColor = false;
            btnSource.Click += btnSource_Click;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(272, 47);
            txtSource.Multiline = true;
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(418, 35);
            txtSource.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 0;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(36, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(706, 29);
            progressBar1.TabIndex = 2;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(20, 20);
            statusBar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblStatus });
            statusBar.Location = new Point(0, 400);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(800, 24);
            statusBar.TabIndex = 2;
            statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 18);
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 18);
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(statusBar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bai06";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSource;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnCopy;
        private Button btnDest;
        private TextBox txtDest;
        private Label label2;
        private Button btnSource;
        private ProgressBar progressBar1;
        private ToolTip toolTip1;
        private StatusStrip statusBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblStatus;
    }
}
