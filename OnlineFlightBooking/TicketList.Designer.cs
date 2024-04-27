namespace OnlineFlightBooking
{
    partial class TicketList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLuggage = new System.Windows.Forms.Label();
            this.lblLuggageAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.lblLandingLocation = new System.Windows.Forms.Label();
            this.lblLandingTime = new System.Windows.Forms.Label();
            this.lblTravelTime = new System.Windows.Forms.Label();
            this.lblTravelType = new System.Windows.Forms.Label();
            this.btnPrice = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureTransfer = new System.Windows.Forms.PictureBox();
            this.pictureTicketLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTicketLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLuggage
            // 
            this.lblLuggage.AutoSize = true;
            this.lblLuggage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.lblLuggage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLuggage.ForeColor = System.Drawing.Color.Black;
            this.lblLuggage.Location = new System.Drawing.Point(105, 35);
            this.lblLuggage.Name = "lblLuggage";
            this.lblLuggage.Size = new System.Drawing.Size(63, 17);
            this.lblLuggage.TabIndex = 8;
            this.lblLuggage.Text = "Luggage:";
            this.lblLuggage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLuggage.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblLuggage.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblLuggageAmount
            // 
            this.lblLuggageAmount.AutoEllipsis = true;
            this.lblLuggageAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.lblLuggageAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLuggageAmount.ForeColor = System.Drawing.Color.Black;
            this.lblLuggageAmount.Location = new System.Drawing.Point(169, 35);
            this.lblLuggageAmount.Name = "lblLuggageAmount";
            this.lblLuggageAmount.Size = new System.Drawing.Size(69, 17);
            this.lblLuggageAmount.TabIndex = 9;
            this.lblLuggageAmount.Text = "15 Kg";
            this.lblLuggageAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLuggageAmount.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblLuggageAmount.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "--------------------------------------->";
            this.label2.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoEllipsis = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartureTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureTime.Location = new System.Drawing.Point(220, 12);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(87, 20);
            this.lblDepartureTime.TabIndex = 11;
            this.lblDepartureTime.Text = "15:00";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureTime.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblDepartureTime.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.AutoEllipsis = true;
            this.lblDepartureLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartureLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureLocation.Location = new System.Drawing.Point(220, 60);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(87, 20);
            this.lblDepartureLocation.TabIndex = 12;
            this.lblDepartureLocation.Text = "IST";
            this.lblDepartureLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureLocation.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblDepartureLocation.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblLandingLocation
            // 
            this.lblLandingLocation.AutoEllipsis = true;
            this.lblLandingLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLandingLocation.Location = new System.Drawing.Point(409, 62);
            this.lblLandingLocation.Name = "lblLandingLocation";
            this.lblLandingLocation.Size = new System.Drawing.Size(79, 20);
            this.lblLandingLocation.TabIndex = 14;
            this.lblLandingLocation.Text = "ABD";
            this.lblLandingLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLandingLocation.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblLandingLocation.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblLandingTime
            // 
            this.lblLandingTime.AutoEllipsis = true;
            this.lblLandingTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLandingTime.Location = new System.Drawing.Point(405, 12);
            this.lblLandingTime.Name = "lblLandingTime";
            this.lblLandingTime.Size = new System.Drawing.Size(85, 20);
            this.lblLandingTime.TabIndex = 13;
            this.lblLandingTime.Text = "20:00";
            this.lblLandingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLandingTime.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblLandingTime.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblTravelTime
            // 
            this.lblTravelTime.AutoEllipsis = true;
            this.lblTravelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTravelTime.Location = new System.Drawing.Point(297, 13);
            this.lblTravelTime.Name = "lblTravelTime";
            this.lblTravelTime.Size = new System.Drawing.Size(117, 17);
            this.lblTravelTime.TabIndex = 15;
            this.lblTravelTime.Text = "5 Hour";
            this.lblTravelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTravelTime.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblTravelTime.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // lblTravelType
            // 
            this.lblTravelType.AutoEllipsis = true;
            this.lblTravelType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTravelType.Location = new System.Drawing.Point(300, 63);
            this.lblTravelType.Name = "lblTravelType";
            this.lblTravelType.Size = new System.Drawing.Size(114, 17);
            this.lblTravelType.TabIndex = 16;
            this.lblTravelType.Text = "Direct";
            this.lblTravelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTravelType.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.lblTravelType.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(496, 7);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrice.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrice.Size = new System.Drawing.Size(133, 77);
            this.btnPrice.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateCommon.Border.ColorAngle = 45F;
            this.btnPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrice.StateCommon.Border.Rounding = 20;
            this.btnPrice.StateCommon.Border.Width = 3;
            this.btnPrice.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPrice.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnPrice.StateNormal.Border.ColorAngle = 45F;
            this.btnPrice.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrice.StateNormal.Border.Rounding = 20;
            this.btnPrice.StateNormal.Border.Width = 3;
            this.btnPrice.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrice.TabIndex = 19;
            this.btnPrice.Values.Text = "2.476 TL";
            this.btnPrice.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.btnPrice.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // pictureTransfer
            // 
            this.pictureTransfer.Image = global::OnlineFlightBooking.Properties.Resources.dotIcon;
            this.pictureTransfer.Location = new System.Drawing.Point(337, 36);
            this.pictureTransfer.Name = "pictureTransfer";
            this.pictureTransfer.Size = new System.Drawing.Size(37, 20);
            this.pictureTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTransfer.TabIndex = 18;
            this.pictureTransfer.TabStop = false;
            this.pictureTransfer.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.pictureTransfer.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // pictureTicketLogo
            // 
            this.pictureTicketLogo.Image = global::OnlineFlightBooking.Properties.Resources.flightlogo;
            this.pictureTicketLogo.Location = new System.Drawing.Point(17, 12);
            this.pictureTicketLogo.Name = "pictureTicketLogo";
            this.pictureTicketLogo.Size = new System.Drawing.Size(82, 70);
            this.pictureTicketLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureTicketLogo.TabIndex = 0;
            this.pictureTicketLogo.TabStop = false;
            this.pictureTicketLogo.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.pictureTicketLogo.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(17, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 20;
            this.panel1.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            // 
            // TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.pictureTransfer);
            this.Controls.Add(this.lblTravelType);
            this.Controls.Add(this.lblTravelTime);
            this.Controls.Add(this.lblLandingLocation);
            this.Controls.Add(this.lblLandingTime);
            this.Controls.Add(this.lblDepartureLocation);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLuggageAmount);
            this.Controls.Add(this.lblLuggage);
            this.Controls.Add(this.pictureTicketLogo);
            this.Name = "TicketList";
            this.Size = new System.Drawing.Size(649, 99);
            this.MouseEnter += new System.EventHandler(this.TicketList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TicketList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTicketLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureTicketLogo;
        private System.Windows.Forms.Label lblLuggage;
        private System.Windows.Forms.Label lblLuggageAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.Label lblLandingLocation;
        private System.Windows.Forms.Label lblLandingTime;
        private System.Windows.Forms.Label lblTravelTime;
        private System.Windows.Forms.Label lblTravelType;
        private System.Windows.Forms.PictureBox pictureTransfer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrice;
        private System.Windows.Forms.Panel panel1;
    }
}
