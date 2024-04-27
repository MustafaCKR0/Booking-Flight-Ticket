namespace OnlineFlightBooking
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.MainPageFormKryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.MainPageLabelDate = new System.Windows.Forms.Label();
            this.MainPageLabelTime = new System.Windows.Forms.Label();
            this.MainPageTimerDate = new System.Windows.Forms.Timer(this.components);
            this.MainPageTimerImage = new System.Windows.Forms.Timer(this.components);
            this.MainPageImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainPagePictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.MainPagePictureBoxImage = new System.Windows.Forms.PictureBox();
            this.MainPageButtonTicket = new System.Windows.Forms.Button();
            this.MainPageButtonMyReservation = new System.Windows.Forms.Button();
            this.MainPageElipseToolImages = new ElipseToolDemo.ElipseTool();
            this.MainPageElipseToolMyReservations = new ElipseToolDemo.ElipseTool();
            this.MainPageElipseToolTicket = new ElipseToolDemo.ElipseTool();
            this.MainPageElipseToolLogo = new ElipseToolDemo.ElipseTool();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageFormKryptonPalette
            // 
            this.MainPageFormKryptonPalette.ButtonSpecs.FormClose.Image = global::OnlineFlightBooking.Properties.Resources.redCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::OnlineFlightBooking.Properties.Resources.icons8_cancel_26;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::OnlineFlightBooking.Properties.Resources.icons8_cancel_26;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMax.Image = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMin.Image = global::OnlineFlightBooking.Properties.Resources.greenCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::OnlineFlightBooking.Properties.Resources.greenCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::OnlineFlightBooking.Properties.Resources.greenCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormRestore.Image = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::OnlineFlightBooking.Properties.Resources.yellowCircle;
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPageFormKryptonPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.MainPageFormKryptonPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPageFormKryptonPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.MainPageFormKryptonPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.MainPageFormKryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageFormKryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.MainPageFormKryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // MainPageLabelDate
            // 
            this.MainPageLabelDate.AutoSize = true;
            this.MainPageLabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainPageLabelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.MainPageLabelDate.Location = new System.Drawing.Point(687, 9);
            this.MainPageLabelDate.Name = "MainPageLabelDate";
            this.MainPageLabelDate.Size = new System.Drawing.Size(45, 20);
            this.MainPageLabelDate.TabIndex = 0;
            this.MainPageLabelDate.Text = "Date";
            // 
            // MainPageLabelTime
            // 
            this.MainPageLabelTime.AutoSize = true;
            this.MainPageLabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainPageLabelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.MainPageLabelTime.Location = new System.Drawing.Point(717, 29);
            this.MainPageLabelTime.Name = "MainPageLabelTime";
            this.MainPageLabelTime.Size = new System.Drawing.Size(46, 20);
            this.MainPageLabelTime.TabIndex = 1;
            this.MainPageLabelTime.Text = "Time";
            // 
            // MainPageTimerDate
            // 
            this.MainPageTimerDate.Enabled = true;
            this.MainPageTimerDate.Tick += new System.EventHandler(this.MainPageTimerDate_Tick_1);
            // 
            // MainPageTimerImage
            // 
            this.MainPageTimerImage.Enabled = true;
            this.MainPageTimerImage.Interval = 2000;
            this.MainPageTimerImage.Tick += new System.EventHandler(this.MainPageTimerImage_Tick_1);
            // 
            // MainPageImageList
            // 
            this.MainPageImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainPageImageList.ImageStream")));
            this.MainPageImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainPageImageList.Images.SetKeyName(0, "How about a nice trip in Cappadocia.png");
            this.MainPageImageList.Images.SetKeyName(1, "Would you like to watch the Aurora borealis in Norway (1).png");
            this.MainPageImageList.Images.SetKeyName(2, "Bir alt başlık ekleyin.png");
            this.MainPageImageList.Images.SetKeyName(3, "Aren\'t the cherry blossoms in Japan lovely.png");
            this.MainPageImageList.Images.SetKeyName(4, "WELCOME , where do you want to go.png");
            // 
            // MainPagePictureBoxLogo
            // 
            this.MainPagePictureBoxLogo.Image = global::OnlineFlightBooking.Properties.Resources.images;
            this.MainPagePictureBoxLogo.Location = new System.Drawing.Point(27, 12);
            this.MainPagePictureBoxLogo.Name = "MainPagePictureBoxLogo";
            this.MainPagePictureBoxLogo.Size = new System.Drawing.Size(171, 109);
            this.MainPagePictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPagePictureBoxLogo.TabIndex = 3;
            this.MainPagePictureBoxLogo.TabStop = false;
            // 
            // MainPagePictureBoxImage
            // 
            this.MainPagePictureBoxImage.Image = global::OnlineFlightBooking.Properties.Resources.WELCOME___where_do_you_want_to_go;
            this.MainPagePictureBoxImage.Location = new System.Drawing.Point(229, 45);
            this.MainPagePictureBoxImage.Name = "MainPagePictureBoxImage";
            this.MainPagePictureBoxImage.Size = new System.Drawing.Size(437, 269);
            this.MainPagePictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPagePictureBoxImage.TabIndex = 2;
            this.MainPagePictureBoxImage.TabStop = false;
            // 
            // MainPageButtonTicket
            // 
            this.MainPageButtonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.MainPageButtonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPageButtonTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainPageButtonTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageButtonTicket.Location = new System.Drawing.Point(229, 342);
            this.MainPageButtonTicket.Name = "MainPageButtonTicket";
            this.MainPageButtonTicket.Size = new System.Drawing.Size(190, 56);
            this.MainPageButtonTicket.TabIndex = 4;
            this.MainPageButtonTicket.Text = "Get Ticket";
            this.MainPageButtonTicket.UseVisualStyleBackColor = false;
            // 
            // MainPageButtonMyReservation
            // 
            this.MainPageButtonMyReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.MainPageButtonMyReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPageButtonMyReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainPageButtonMyReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.MainPageButtonMyReservation.Location = new System.Drawing.Point(482, 342);
            this.MainPageButtonMyReservation.Name = "MainPageButtonMyReservation";
            this.MainPageButtonMyReservation.Size = new System.Drawing.Size(184, 56);
            this.MainPageButtonMyReservation.TabIndex = 5;
            this.MainPageButtonMyReservation.Text = "My Reservations";
            this.MainPageButtonMyReservation.UseVisualStyleBackColor = false;
            // 
            // MainPageElipseToolImages
            // 
            this.MainPageElipseToolImages.CornerRadius = 40;
            this.MainPageElipseToolImages.TargetControl = this.MainPagePictureBoxImage;
            // 
            // MainPageElipseToolMyReservations
            // 
            this.MainPageElipseToolMyReservations.CornerRadius = 40;
            this.MainPageElipseToolMyReservations.TargetControl = this.MainPageButtonMyReservation;
            // 
            // MainPageElipseToolTicket
            // 
            this.MainPageElipseToolTicket.CornerRadius = 40;
            this.MainPageElipseToolTicket.TargetControl = this.MainPageButtonTicket;
            // 
            // MainPageElipseToolLogo
            // 
            this.MainPageElipseToolLogo.CornerRadius = 40;
            this.MainPageElipseToolLogo.TargetControl = this.MainPagePictureBoxLogo;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPageButtonMyReservation);
            this.Controls.Add(this.MainPageButtonTicket);
            this.Controls.Add(this.MainPagePictureBoxLogo);
            this.Controls.Add(this.MainPagePictureBoxImage);
            this.Controls.Add(this.MainPageLabelTime);
            this.Controls.Add(this.MainPageLabelDate);
            this.Name = "MainPageForm";
            this.Palette = this.MainPageFormKryptonPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPagePictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPageFormKryptonPalette;
        private System.Windows.Forms.Label MainPageLabelDate;
        private System.Windows.Forms.Label MainPageLabelTime;
        private System.Windows.Forms.Timer MainPageTimerDate;
        private System.Windows.Forms.Timer MainPageTimerImage;
        private System.Windows.Forms.ImageList MainPageImageList;
        private System.Windows.Forms.PictureBox MainPagePictureBoxImage;
        private System.Windows.Forms.PictureBox MainPagePictureBoxLogo;
        private System.Windows.Forms.Button MainPageButtonTicket;
        private System.Windows.Forms.Button MainPageButtonMyReservation;
        private ElipseToolDemo.ElipseTool MainPageElipseToolImages;
        private ElipseToolDemo.ElipseTool MainPageElipseToolMyReservations;
        private ElipseToolDemo.ElipseTool MainPageElipseToolTicket;
        private ElipseToolDemo.ElipseTool MainPageElipseToolLogo;
    }
}

