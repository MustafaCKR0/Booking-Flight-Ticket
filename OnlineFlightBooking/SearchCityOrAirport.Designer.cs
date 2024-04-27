namespace OnlineFlightBooking
{
    partial class SearchCityOrAirport
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
            this.lblCityCountry = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.btnAirportSelect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // lblCityCountry
            // 
            this.lblCityCountry.AutoEllipsis = true;
            this.lblCityCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblCityCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCityCountry.Location = new System.Drawing.Point(18, 4);
            this.lblCityCountry.Name = "lblCityCountry";
            this.lblCityCountry.Size = new System.Drawing.Size(200, 20);
            this.lblCityCountry.TabIndex = 13;
            this.lblCityCountry.Text = "İstanbul, Turkey";
            this.lblCityCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCityCountry.Click += new System.EventHandler(this.btnAirportSelect_Click);
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoEllipsis = true;
            this.lblAirportName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblAirportName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAirportName.Location = new System.Drawing.Point(18, 19);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(200, 20);
            this.lblAirportName.TabIndex = 14;
            this.lblAirportName.Text = "Sabiha Gökçen Havalimanı";
            this.lblAirportName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAirportName.Click += new System.EventHandler(this.btnAirportSelect_Click);
            // 
            // btnAirportSelect
            // 
            this.btnAirportSelect.Location = new System.Drawing.Point(0, 0);
            this.btnAirportSelect.Name = "btnAirportSelect";
            this.btnAirportSelect.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAirportSelect.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAirportSelect.Size = new System.Drawing.Size(235, 42);
            this.btnAirportSelect.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateCommon.Border.ColorAngle = 45F;
            this.btnAirportSelect.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAirportSelect.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAirportSelect.StateCommon.Border.Rounding = 20;
            this.btnAirportSelect.StateCommon.Border.Width = 3;
            this.btnAirportSelect.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnAirportSelect.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.btnAirportSelect.StateNormal.Border.ColorAngle = 45F;
            this.btnAirportSelect.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAirportSelect.StateNormal.Border.Rounding = 20;
            this.btnAirportSelect.StateNormal.Border.Width = 3;
            this.btnAirportSelect.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirportSelect.TabIndex = 20;
            this.btnAirportSelect.Values.Text = "2.476 TL";
            this.btnAirportSelect.Click += new System.EventHandler(this.btnAirportSelect_Click);
            // 
            // SearchCityOrAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(126)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.lblCityCountry);
            this.Controls.Add(this.lblAirportName);
            this.Controls.Add(this.btnAirportSelect);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SearchCityOrAirport";
            this.Size = new System.Drawing.Size(238, 41);
            this.MouseEnter += new System.EventHandler(this.SearchCityOrAirport_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCityCountry;
        private System.Windows.Forms.Label lblAirportName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAirportSelect;
    }
}
