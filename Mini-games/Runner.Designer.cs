
namespace Runner
{
    partial class Runner
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.floor = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.obstacle = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Cursor = System.Windows.Forms.Cursors.Default;
            this.floor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.floor.Location = new System.Drawing.Point(0, 435);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(618, 40);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            this.floor.Tag = "floor";
            // 
            // trex
            // 
            this.trex.BackColor = System.Drawing.Color.Transparent;
            this.trex.Image = global::Runner.Properties.Resources.tyrannosaurus_dino_t_rex_t_rex_chrome_vr_jump_trex_runner_lava_jump_dinosaur_7a6d98d6824c2fc08c10e5a6a2d66e74;
            this.trex.Location = new System.Drawing.Point(52, 376);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(44, 60);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            this.trex.Tag = "trex";
            // 
            // obstacle
            // 
            this.obstacle.BackColor = System.Drawing.Color.Black;
            this.obstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.obstacle.Location = new System.Drawing.Point(282, 386);
            this.obstacle.Name = "obstacle";
            this.obstacle.Size = new System.Drawing.Size(25, 50);
            this.obstacle.TabIndex = 2;
            this.obstacle.TabStop = false;
            this.obstacle.Tag = "obstacle";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(48, 13);
            this.scoreText.TabIndex = 3;
            this.scoreText.Tag = "scoreText";
            this.scoreText.Text = "Score- 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tag = "gameTimer";
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(313, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.floor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obstacle;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

