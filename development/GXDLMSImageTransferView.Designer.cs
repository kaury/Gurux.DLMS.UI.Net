using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSImageTransferView
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
        private GroupBox groupBox1;
        private GXValueField ImageBlockSizeTB;
        private Label ImageBlockSizeLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label ImageTransferredBlocksStatusLbl;
        private GXValueField ImageFirstNotTransferredBlockNumberTB;
        private Label ImageFirstNotTransferredBlockNumberLbl;
        private CheckBox ImageTransferEnabledCB;
        private Label ImageTransferEnabledLbl;
        private Label ImageTransferStatusLbl;
        private Label ImageActivateInfoLbl;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSImageTransferView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImageTransferredBlocksStatusTB = new System.Windows.Forms.TextBox();
            this.ImageTransferStatusTb = new System.Windows.Forms.TextBox();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.DelayTb = new System.Windows.Forms.TextBox();
            this.ManualBtn = new System.Windows.Forms.CheckBox();
            this.ImagesView = new System.Windows.Forms.ListView();
            this.SizeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdentificationCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignatureCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionList = new System.Windows.Forms.ListView();
            this.TimeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageActivateInfoLbl = new System.Windows.Forms.Label();
            this.ImageTransferStatusLbl = new System.Windows.Forms.Label();
            this.ImageTransferEnabledCB = new System.Windows.Forms.CheckBox();
            this.ImageTransferEnabledLbl = new System.Windows.Forms.Label();
            this.ImageFirstNotTransferredBlockNumberLbl = new System.Windows.Forms.Label();
            this.ImageTransferredBlocksStatusLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ImageBlockSizeLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActivateImageBtn = new Gurux.DLMS.UI.GXButton();
            this.VerifyImageBtn = new Gurux.DLMS.UI.GXButton();
            this.UpdateImageBtn = new Gurux.DLMS.UI.GXButton();
            this.ImageFirstNotTransferredBlockNumberTB = new Gurux.DLMS.UI.GXValueField();
            this.ImageBlockSizeTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ImageTransferredBlocksStatusTB);
            this.groupBox1.Controls.Add(this.ImageTransferStatusTb);
            this.groupBox1.Controls.Add(this.DelayLbl);
            this.groupBox1.Controls.Add(this.DelayTb);
            this.groupBox1.Controls.Add(this.ManualBtn);
            this.groupBox1.Controls.Add(this.ActivateImageBtn);
            this.groupBox1.Controls.Add(this.VerifyImageBtn);
            this.groupBox1.Controls.Add(this.ImagesView);
            this.groupBox1.Controls.Add(this.DescriptionList);
            this.groupBox1.Controls.Add(this.UpdateImageBtn);
            this.groupBox1.Controls.Add(this.ImageActivateInfoLbl);
            this.groupBox1.Controls.Add(this.ImageTransferStatusLbl);
            this.groupBox1.Controls.Add(this.ImageTransferEnabledCB);
            this.groupBox1.Controls.Add(this.ImageTransferEnabledLbl);
            this.groupBox1.Controls.Add(this.ImageFirstNotTransferredBlockNumberTB);
            this.groupBox1.Controls.Add(this.ImageFirstNotTransferredBlockNumberLbl);
            this.groupBox1.Controls.Add(this.ImageTransferredBlocksStatusLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ImageBlockSizeTB);
            this.groupBox1.Controls.Add(this.ImageBlockSizeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Transfer Object";
            // 
            // ImageTransferredBlocksStatusTB
            // 
            this.ImageTransferredBlocksStatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageTransferredBlocksStatusTB.Location = new System.Drawing.Point(105, 97);
            this.ImageTransferredBlocksStatusTB.Multiline = true;
            this.ImageTransferredBlocksStatusTB.Name = "ImageTransferredBlocksStatusTB";
            this.ImageTransferredBlocksStatusTB.Size = new System.Drawing.Size(335, 74);
            this.ImageTransferredBlocksStatusTB.TabIndex = 30;
            // 
            // ImageTransferStatusTb
            // 
            this.ImageTransferStatusTb.Location = new System.Drawing.Point(312, 178);
            this.ImageTransferStatusTb.Name = "ImageTransferStatusTb";
            this.ImageTransferStatusTb.ReadOnly = true;
            this.ImageTransferStatusTb.Size = new System.Drawing.Size(124, 20);
            this.ImageTransferStatusTb.TabIndex = 29;
            // 
            // DelayLbl
            // 
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.Location = new System.Drawing.Point(32, 310);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(34, 13);
            this.DelayLbl.TabIndex = 28;
            this.DelayLbl.Text = "Delay";
            // 
            // DelayTb
            // 
            this.DelayTb.Location = new System.Drawing.Point(104, 305);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(81, 20);
            this.DelayTb.TabIndex = 27;
            // 
            // ManualBtn
            // 
            this.ManualBtn.AutoSize = true;
            this.ManualBtn.Location = new System.Drawing.Point(10, 282);
            this.ManualBtn.Name = "ManualBtn";
            this.ManualBtn.Size = new System.Drawing.Size(61, 17);
            this.ManualBtn.TabIndex = 26;
            this.ManualBtn.Text = "Manual";
            this.ManualBtn.UseVisualStyleBackColor = true;
            this.ManualBtn.CheckedChanged += new System.EventHandler(this.ManualBtn_CheckedChanged);
            // 
            // ImagesView
            // 
            this.ImagesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SizeCh,
            this.IdentificationCh,
            this.SignatureCh});
            this.ImagesView.FullRowSelect = true;
            this.ImagesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ImagesView.HideSelection = false;
            this.ImagesView.Location = new System.Drawing.Point(103, 203);
            this.ImagesView.Name = "ImagesView";
            this.ImagesView.Size = new System.Drawing.Size(333, 96);
            this.ImagesView.TabIndex = 23;
            this.ImagesView.UseCompatibleStateImageBehavior = false;
            this.ImagesView.View = System.Windows.Forms.View.Details;
            // 
            // SizeCh
            // 
            this.SizeCh.Text = "Size";
            this.SizeCh.Width = 77;
            // 
            // IdentificationCh
            // 
            this.IdentificationCh.Text = "Identification";
            this.IdentificationCh.Width = 112;
            // 
            // SignatureCh
            // 
            this.SignatureCh.Text = "Signature";
            this.SignatureCh.Width = 121;
            // 
            // DescriptionList
            // 
            this.DescriptionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeCh,
            this.DescriptionCH});
            this.DescriptionList.FullRowSelect = true;
            this.DescriptionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DescriptionList.HideSelection = false;
            this.DescriptionList.Location = new System.Drawing.Point(9, 334);
            this.DescriptionList.Name = "DescriptionList";
            this.DescriptionList.Size = new System.Drawing.Size(426, 136);
            this.DescriptionList.TabIndex = 9;
            this.DescriptionList.UseCompatibleStateImageBehavior = false;
            this.DescriptionList.View = System.Windows.Forms.View.Details;
            // 
            // TimeCh
            // 
            this.TimeCh.Text = "Time";
            this.TimeCh.Width = 91;
            // 
            // DescriptionCH
            // 
            this.DescriptionCH.Text = "Description";
            this.DescriptionCH.Width = 216;
            // 
            // ImageActivateInfoLbl
            // 
            this.ImageActivateInfoLbl.AutoSize = true;
            this.ImageActivateInfoLbl.Location = new System.Drawing.Point(6, 203);
            this.ImageActivateInfoLbl.Name = "ImageActivateInfoLbl";
            this.ImageActivateInfoLbl.Size = new System.Drawing.Size(44, 13);
            this.ImageActivateInfoLbl.TabIndex = 22;
            this.ImageActivateInfoLbl.Text = "Images:";
            // 
            // ImageTransferStatusLbl
            // 
            this.ImageTransferStatusLbl.AutoSize = true;
            this.ImageTransferStatusLbl.Location = new System.Drawing.Point(234, 178);
            this.ImageTransferStatusLbl.Name = "ImageTransferStatusLbl";
            this.ImageTransferStatusLbl.Size = new System.Drawing.Size(40, 13);
            this.ImageTransferStatusLbl.TabIndex = 20;
            this.ImageTransferStatusLbl.Text = "Status:";
            // 
            // ImageTransferEnabledCB
            // 
            this.ImageTransferEnabledCB.Location = new System.Drawing.Point(104, 177);
            this.ImageTransferEnabledCB.Name = "ImageTransferEnabledCB";
            this.ImageTransferEnabledCB.Size = new System.Drawing.Size(27, 17);
            this.ImageTransferEnabledCB.TabIndex = 5;
            this.ImageTransferEnabledCB.UseVisualStyleBackColor = false;
            this.ImageTransferEnabledCB.CheckedChanged += new System.EventHandler(this.ImageTransferEnabledCB_CheckedChanged);
            // 
            // ImageTransferEnabledLbl
            // 
            this.ImageTransferEnabledLbl.AutoSize = true;
            this.ImageTransferEnabledLbl.Location = new System.Drawing.Point(7, 178);
            this.ImageTransferEnabledLbl.Name = "ImageTransferEnabledLbl";
            this.ImageTransferEnabledLbl.Size = new System.Drawing.Size(49, 13);
            this.ImageTransferEnabledLbl.TabIndex = 18;
            this.ImageTransferEnabledLbl.Text = "Enabled:";
            // 
            // ImageFirstNotTransferredBlockNumberLbl
            // 
            this.ImageFirstNotTransferredBlockNumberLbl.AutoSize = true;
            this.ImageFirstNotTransferredBlockNumberLbl.Location = new System.Drawing.Point(230, 74);
            this.ImageFirstNotTransferredBlockNumberLbl.Name = "ImageFirstNotTransferredBlockNumberLbl";
            this.ImageFirstNotTransferredBlockNumberLbl.Size = new System.Drawing.Size(59, 13);
            this.ImageFirstNotTransferredBlockNumberLbl.TabIndex = 9;
            this.ImageFirstNotTransferredBlockNumberLbl.Text = "First Block:";
            // 
            // ImageTransferredBlocksStatusLbl
            // 
            this.ImageTransferredBlocksStatusLbl.AutoSize = true;
            this.ImageTransferredBlocksStatusLbl.Location = new System.Drawing.Point(7, 100);
            this.ImageTransferredBlocksStatusLbl.Name = "ImageTransferredBlocksStatusLbl";
            this.ImageTransferredBlocksStatusLbl.Size = new System.Drawing.Size(75, 13);
            this.ImageTransferredBlocksStatusLbl.TabIndex = 7;
            this.ImageTransferredBlocksStatusLbl.Text = "Blocks Status:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(337, 20);
            this.DescriptionTB.TabIndex = 0;
            // 
            // ImageBlockSizeLbl
            // 
            this.ImageBlockSizeLbl.AutoSize = true;
            this.ImageBlockSizeLbl.Location = new System.Drawing.Point(7, 74);
            this.ImageBlockSizeLbl.Name = "ImageBlockSizeLbl";
            this.ImageBlockSizeLbl.Size = new System.Drawing.Size(92, 13);
            this.ImageBlockSizeLbl.TabIndex = 2;
            this.ImageBlockSizeLbl.Text = "Image Block Size:";
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 48);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 0;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ActivateImageBtn
            // 
            this.ActivateImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivateImageBtn.Index = 4;
            this.ActivateImageBtn.Location = new System.Drawing.Point(241, 305);
            this.ActivateImageBtn.Name = "ActivateImageBtn";
            this.ActivateImageBtn.Size = new System.Drawing.Size(61, 23);
            this.ActivateImageBtn.TabIndex = 25;
            this.ActivateImageBtn.Text = "Activate Image...";
            this.ActivateImageBtn.UseVisualStyleBackColor = true;
            // 
            // VerifyImageBtn
            // 
            this.VerifyImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyImageBtn.Index = 3;
            this.VerifyImageBtn.Location = new System.Drawing.Point(308, 305);
            this.VerifyImageBtn.Name = "VerifyImageBtn";
            this.VerifyImageBtn.Size = new System.Drawing.Size(61, 23);
            this.VerifyImageBtn.TabIndex = 24;
            this.VerifyImageBtn.Text = "Verify Image...";
            this.VerifyImageBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateImageBtn
            // 
            this.UpdateImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateImageBtn.Index = 1;
            this.UpdateImageBtn.Location = new System.Drawing.Point(375, 305);
            this.UpdateImageBtn.Name = "UpdateImageBtn";
            this.UpdateImageBtn.Size = new System.Drawing.Size(61, 23);
            this.UpdateImageBtn.TabIndex = 8;
            this.UpdateImageBtn.Text = "Update Image...";
            this.UpdateImageBtn.UseVisualStyleBackColor = true;
            // 
            // ImageFirstNotTransferredBlockNumberTB
            // 
            this.ImageFirstNotTransferredBlockNumberTB.Index = 4;
            this.ImageFirstNotTransferredBlockNumberTB.Location = new System.Drawing.Point(312, 71);
            this.ImageFirstNotTransferredBlockNumberTB.Name = "ImageFirstNotTransferredBlockNumberTB";
            this.ImageFirstNotTransferredBlockNumberTB.NotifyChanges = false;
            this.ImageFirstNotTransferredBlockNumberTB.Size = new System.Drawing.Size(128, 20);
            this.ImageFirstNotTransferredBlockNumberTB.TabIndex = 4;
            this.ImageFirstNotTransferredBlockNumberTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ImageBlockSizeTB
            // 
            this.ImageBlockSizeTB.Index = 2;
            this.ImageBlockSizeTB.Location = new System.Drawing.Point(104, 71);
            this.ImageBlockSizeTB.Name = "ImageBlockSizeTB";
            this.ImageBlockSizeTB.NotifyChanges = false;
            this.ImageBlockSizeTB.Size = new System.Drawing.Size(113, 20);
            this.ImageBlockSizeTB.TabIndex = 2;
            this.ImageBlockSizeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ImageBlockSizeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ImageBlockSizeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(336, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSImageTransferView
            // 
            this.ClientSize = new System.Drawing.Size(485, 500);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSImageTransferView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXButton UpdateImageBtn;
        private ListView DescriptionList;
        private ColumnHeader DescriptionCH;
        private ListView ImagesView;
        private ColumnHeader SizeCh;
        private ColumnHeader IdentificationCh;
        private ColumnHeader SignatureCh;
        private ColumnHeader TimeCh;
        private GXButton VerifyImageBtn;
        private GXButton ActivateImageBtn;
        private Label DelayLbl;
        private TextBox DelayTb;
        private CheckBox ManualBtn;
        private TextBox ImageTransferStatusTb;
        private TextBox ImageTransferredBlocksStatusTB;
    }
}
