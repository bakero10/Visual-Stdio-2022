namespace TalleresFitipaldi.Informe
{
    partial class Informe
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.titulo = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbl_saludo = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.titulo});
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // titulo
            // 
            this.titulo.Font = new DevExpress.Drawing.DXFont("Times New Roman", 27F, DevExpress.Drawing.DXFontStyle.Bold);
            this.titulo.LocationFloat = new DevExpress.Utils.PointFloat(40.27778F, 25.30556F);
            this.titulo.Multiline = true;
            this.titulo.Name = "titulo";
            this.titulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.titulo.SizeF = new System.Drawing.SizeF(569.4445F, 45.91667F);
            this.titulo.StylePriority.UseFont = false;
            this.titulo.Tag = "etiTitulo";
            this.titulo.Text = "TALLERES FITIPALDIS S.A";
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 146.5278F;
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 670.8333F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbl_saludo});
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount()")});
            this.lbl_saludo.LocationFloat = new DevExpress.Utils.PointFloat(40.27778F, 22.52778F);
            this.lbl_saludo.Multiline = true;
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbl_saludo.SizeF = new System.Drawing.SizeF(100F, 23F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.lbl_saludo.Summary = xrSummary1;
            this.lbl_saludo.Text = "labelSaludo";
            // 
            // Informe
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.PageFooter,
            this.reportHeaderBand1});
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 100F, 670.8333F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel labelTitulo;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRLabel titulo;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel lbl_saludo;
    }
}
