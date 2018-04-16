namespace Raising_a_pet
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PetScreen = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Eat = new System.Windows.Forms.Button();
            this.PetTimer = new System.Windows.Forms.Timer(this.components);
            this.PresentHappiness = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PetScreen
            // 
            this.PetScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PetScreen.Location = new System.Drawing.Point(13, 13);
            this.PetScreen.Name = "PetScreen";
            this.PetScreen.Size = new System.Drawing.Size(593, 96);
            this.PetScreen.TabIndex = 0;
            this.PetScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(13, 140);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Eat
            // 
            this.Eat.Location = new System.Drawing.Point(94, 140);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(75, 23);
            this.Eat.TabIndex = 2;
            this.Eat.Text = "Eat";
            this.Eat.UseVisualStyleBackColor = true;
            this.Eat.Click += new System.EventHandler(this.Eat_Click);
            // 
            // PetTimer
            // 
            this.PetTimer.Enabled = true;
            this.PetTimer.Interval = 5000;
            this.PetTimer.Tick += new System.EventHandler(this.PetTimer_Tick);
            // 
            // PresentHappiness
            // 
            this.PresentHappiness.AutoSize = true;
            this.PresentHappiness.Location = new System.Drawing.Point(432, 27);
            this.PresentHappiness.Name = "PresentHappiness";
            this.PresentHappiness.Size = new System.Drawing.Size(38, 12);
            this.PresentHappiness.TabIndex = 3;
            this.PresentHappiness.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 355);
            this.Controls.Add(this.PresentHappiness);
            this.Controls.Add(this.Eat);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.PetScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PetScreen;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Eat;
        private System.Windows.Forms.Timer PetTimer;
        private System.Windows.Forms.Label PresentHappiness;
    }
}

