namespace Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CPU_PR_B = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU_PR_B_T = new CircularProgressBar.CircularProgressBar();
            this.GPU_PR_B = new CircularProgressBar.CircularProgressBar();
            this.GPU_PR_B_T = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // CPU_PR_B
            // 
            this.CPU_PR_B.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPU_PR_B.AnimationSpeed = 500;
            this.CPU_PR_B.BackColor = System.Drawing.Color.Transparent;
            this.CPU_PR_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPU_PR_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPU_PR_B.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPU_PR_B.InnerMargin = 2;
            this.CPU_PR_B.InnerWidth = -1;
            this.CPU_PR_B.Location = new System.Drawing.Point(12, 56);
            this.CPU_PR_B.MarqueeAnimationSpeed = 2000;
            this.CPU_PR_B.Name = "CPU_PR_B";
            this.CPU_PR_B.OuterColor = System.Drawing.Color.Gray;
            this.CPU_PR_B.OuterMargin = -25;
            this.CPU_PR_B.OuterWidth = 26;
            this.CPU_PR_B.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CPU_PR_B.ProgressWidth = 25;
            this.CPU_PR_B.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPU_PR_B.Size = new System.Drawing.Size(195, 195);
            this.CPU_PR_B.StartAngle = 270;
            this.CPU_PR_B.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_PR_B.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPU_PR_B.SubscriptText = "";
            this.CPU_PR_B.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_PR_B.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPU_PR_B.SuperscriptText = "";
            this.CPU_PR_B.TabIndex = 0;
            this.CPU_PR_B.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPU_PR_B.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU_PR_B_T
            // 
            this.CPU_PR_B_T.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPU_PR_B_T.AnimationSpeed = 500;
            this.CPU_PR_B_T.BackColor = System.Drawing.Color.Transparent;
            this.CPU_PR_B_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPU_PR_B_T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPU_PR_B_T.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPU_PR_B_T.InnerMargin = 2;
            this.CPU_PR_B_T.InnerWidth = -1;
            this.CPU_PR_B_T.Location = new System.Drawing.Point(145, 257);
            this.CPU_PR_B_T.MarqueeAnimationSpeed = 2000;
            this.CPU_PR_B_T.Name = "CPU_PR_B_T";
            this.CPU_PR_B_T.OuterColor = System.Drawing.Color.Gray;
            this.CPU_PR_B_T.OuterMargin = -25;
            this.CPU_PR_B_T.OuterWidth = 26;
            this.CPU_PR_B_T.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CPU_PR_B_T.ProgressWidth = 20;
            this.CPU_PR_B_T.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPU_PR_B_T.Size = new System.Drawing.Size(130, 130);
            this.CPU_PR_B_T.StartAngle = 270;
            this.CPU_PR_B_T.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_PR_B_T.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPU_PR_B_T.SubscriptText = "";
            this.CPU_PR_B_T.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU_PR_B_T.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPU_PR_B_T.SuperscriptText = "";
            this.CPU_PR_B_T.TabIndex = 1;
            this.CPU_PR_B_T.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPU_PR_B_T.Value = 68;
            // 
            // GPU_PR_B
            // 
            this.GPU_PR_B.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GPU_PR_B.AnimationSpeed = 500;
            this.GPU_PR_B.BackColor = System.Drawing.Color.Transparent;
            this.GPU_PR_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPU_PR_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GPU_PR_B.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GPU_PR_B.InnerMargin = 2;
            this.GPU_PR_B.InnerWidth = -1;
            this.GPU_PR_B.Location = new System.Drawing.Point(410, 56);
            this.GPU_PR_B.MarqueeAnimationSpeed = 2000;
            this.GPU_PR_B.Name = "GPU_PR_B";
            this.GPU_PR_B.OuterColor = System.Drawing.Color.Gray;
            this.GPU_PR_B.OuterMargin = -25;
            this.GPU_PR_B.OuterWidth = 26;
            this.GPU_PR_B.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GPU_PR_B.ProgressWidth = 25;
            this.GPU_PR_B.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.GPU_PR_B.Size = new System.Drawing.Size(195, 195);
            this.GPU_PR_B.StartAngle = 270;
            this.GPU_PR_B.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPU_PR_B.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.GPU_PR_B.SubscriptText = "";
            this.GPU_PR_B.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPU_PR_B.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.GPU_PR_B.SuperscriptText = "";
            this.GPU_PR_B.TabIndex = 2;
            this.GPU_PR_B.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GPU_PR_B.Value = 68;
            // 
            // GPU_PR_B_T
            // 
            this.GPU_PR_B_T.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GPU_PR_B_T.AnimationSpeed = 500;
            this.GPU_PR_B_T.BackColor = System.Drawing.Color.Transparent;
            this.GPU_PR_B_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPU_PR_B_T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GPU_PR_B_T.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GPU_PR_B_T.InnerMargin = 2;
            this.GPU_PR_B_T.InnerWidth = -1;
            this.GPU_PR_B_T.Location = new System.Drawing.Point(541, 257);
            this.GPU_PR_B_T.MarqueeAnimationSpeed = 2000;
            this.GPU_PR_B_T.Name = "GPU_PR_B_T";
            this.GPU_PR_B_T.OuterColor = System.Drawing.Color.Gray;
            this.GPU_PR_B_T.OuterMargin = -25;
            this.GPU_PR_B_T.OuterWidth = 26;
            this.GPU_PR_B_T.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GPU_PR_B_T.ProgressWidth = 20;
            this.GPU_PR_B_T.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPU_PR_B_T.Size = new System.Drawing.Size(130, 130);
            this.GPU_PR_B_T.StartAngle = 270;
            this.GPU_PR_B_T.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPU_PR_B_T.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.GPU_PR_B_T.SubscriptText = "";
            this.GPU_PR_B_T.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPU_PR_B_T.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.GPU_PR_B_T.SuperscriptText = "";
            this.GPU_PR_B_T.TabIndex = 3;
            this.GPU_PR_B_T.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GPU_PR_B_T.Value = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GPU_PR_B_T);
            this.Controls.Add(this.GPU_PR_B);
            this.Controls.Add(this.CPU_PR_B_T);
            this.Controls.Add(this.CPU_PR_B);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar CPU_PR_B;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar CPU_PR_B_T;
        private CircularProgressBar.CircularProgressBar GPU_PR_B;
        private CircularProgressBar.CircularProgressBar GPU_PR_B_T;
    }
}