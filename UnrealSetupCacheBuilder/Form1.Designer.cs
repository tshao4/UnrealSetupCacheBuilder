namespace UnrealSetupCacheBuilder
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.PGBar = new System.Windows.Forms.ProgressBar();
            this.TB_Engine = new System.Windows.Forms.TextBox();
            this.TB_Cache = new System.Windows.Forms.TextBox();
            this.TB_Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Engine = new System.Windows.Forms.Button();
            this.BTN_Cache = new System.Windows.Forms.Button();
            this.BTN_Target = new System.Windows.Forms.Button();
            this.BTN_Build = new System.Windows.Forms.Button();
            this.LB_Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // PGBar
            // 
            this.PGBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PGBar.Location = new System.Drawing.Point(12, 103);
            this.PGBar.Name = "PGBar";
            this.PGBar.Size = new System.Drawing.Size(380, 23);
            this.PGBar.TabIndex = 0;
            // 
            // TB_Engine
            // 
            this.TB_Engine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Engine.Location = new System.Drawing.Point(66, 12);
            this.TB_Engine.Name = "TB_Engine";
            this.TB_Engine.Size = new System.Drawing.Size(345, 21);
            this.TB_Engine.TabIndex = 1;
            // 
            // TB_Cache
            // 
            this.TB_Cache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Cache.Location = new System.Drawing.Point(66, 39);
            this.TB_Cache.Name = "TB_Cache";
            this.TB_Cache.Size = new System.Drawing.Size(345, 21);
            this.TB_Cache.TabIndex = 1;
            // 
            // TB_Target
            // 
            this.TB_Target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Target.Location = new System.Drawing.Point(66, 66);
            this.TB_Target.Name = "TB_Target";
            this.TB_Target.Size = new System.Drawing.Size(345, 21);
            this.TB_Target.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cache";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target";
            // 
            // BTN_Engine
            // 
            this.BTN_Engine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Engine.Font = new System.Drawing.Font("宋体", 9F);
            this.BTN_Engine.Location = new System.Drawing.Point(417, 10);
            this.BTN_Engine.Name = "BTN_Engine";
            this.BTN_Engine.Size = new System.Drawing.Size(31, 23);
            this.BTN_Engine.TabIndex = 3;
            this.BTN_Engine.Text = "...";
            this.BTN_Engine.UseVisualStyleBackColor = true;
            this.BTN_Engine.Click += new System.EventHandler(this.BTN_Engine_Click);
            // 
            // BTN_Cache
            // 
            this.BTN_Cache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cache.Font = new System.Drawing.Font("宋体", 9F);
            this.BTN_Cache.Location = new System.Drawing.Point(417, 37);
            this.BTN_Cache.Name = "BTN_Cache";
            this.BTN_Cache.Size = new System.Drawing.Size(31, 23);
            this.BTN_Cache.TabIndex = 3;
            this.BTN_Cache.Text = "...";
            this.BTN_Cache.UseVisualStyleBackColor = true;
            this.BTN_Cache.Click += new System.EventHandler(this.BTN_Cache_Click);
            // 
            // BTN_Target
            // 
            this.BTN_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Target.Font = new System.Drawing.Font("宋体", 9F);
            this.BTN_Target.Location = new System.Drawing.Point(417, 64);
            this.BTN_Target.Name = "BTN_Target";
            this.BTN_Target.Size = new System.Drawing.Size(31, 23);
            this.BTN_Target.TabIndex = 3;
            this.BTN_Target.Text = "...";
            this.BTN_Target.UseVisualStyleBackColor = true;
            this.BTN_Target.Click += new System.EventHandler(this.BTN_Target_Click);
            // 
            // BTN_Build
            // 
            this.BTN_Build.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Build.Font = new System.Drawing.Font("宋体", 9F);
            this.BTN_Build.Location = new System.Drawing.Point(398, 103);
            this.BTN_Build.Name = "BTN_Build";
            this.BTN_Build.Size = new System.Drawing.Size(50, 23);
            this.BTN_Build.TabIndex = 3;
            this.BTN_Build.Text = "Build";
            this.BTN_Build.UseVisualStyleBackColor = true;
            this.BTN_Build.Click += new System.EventHandler(this.BTN_Build_Click);
            // 
            // LB_Log
            // 
            this.LB_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_Log.AutoSize = true;
            this.LB_Log.Location = new System.Drawing.Point(12, 129);
            this.LB_Log.Name = "LB_Log";
            this.LB_Log.Size = new System.Drawing.Size(125, 12);
            this.LB_Log.TabIndex = 4;
            this.LB_Log.Text = "Press Build to start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 150);
            this.Controls.Add(this.LB_Log);
            this.Controls.Add(this.BTN_Build);
            this.Controls.Add(this.BTN_Target);
            this.Controls.Add(this.BTN_Cache);
            this.Controls.Add(this.BTN_Engine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Target);
            this.Controls.Add(this.TB_Cache);
            this.Controls.Add(this.TB_Engine);
            this.Controls.Add(this.PGBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UnrealSetupCacheBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.ProgressBar PGBar;
        private System.Windows.Forms.TextBox TB_Engine;
        private System.Windows.Forms.TextBox TB_Cache;
        private System.Windows.Forms.TextBox TB_Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Engine;
        private System.Windows.Forms.Button BTN_Cache;
        private System.Windows.Forms.Button BTN_Target;
        private System.Windows.Forms.Button BTN_Build;
        private System.Windows.Forms.Label LB_Log;
    }
}

