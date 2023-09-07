namespace To_Do_List
{
    partial class todo_item
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todo_item));
            this.lbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.check = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btnModify = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AllowParentOverrides = false;
            this.lbl.AutoEllipsis = false;
            this.lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(53, 13);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl.Size = new System.Drawing.Size(83, 25);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "To Do List";
            this.lbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ActiveImage")));
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowBuffering = false;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AllowZooming = true;
            this.btnDelete.AllowZoomingOnFocus = false;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.ErrorImage = null;
            this.btnDelete.FadeWhenInactive = false;
            this.btnDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageActive")));
            this.btnDelete.ImageLocation = null;
            this.btnDelete.ImageMargin = 20;
            this.btnDelete.ImageSize = new System.Drawing.Size(32, 27);
            this.btnDelete.ImageZoomSize = new System.Drawing.Size(52, 47);
            this.btnDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.InitialImage")));
            this.btnDelete.Location = new System.Drawing.Point(441, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0;
            this.btnDelete.ShowActiveImage = true;
            this.btnDelete.ShowCursorChanges = true;
            this.btnDelete.ShowImageBorders = true;
            this.btnDelete.ShowSizeMarkers = false;
            this.btnDelete.Size = new System.Drawing.Size(52, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.ToolTipText = "";
            this.btnDelete.WaitOnLoad = false;
            this.btnDelete.Zoom = 20;
            this.btnDelete.ZoomSpeed = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // check
            // 
            this.check.AllowBindingControlAnimation = true;
            this.check.AllowBindingControlColorChanges = false;
            this.check.AllowBindingControlLocation = true;
            this.check.AllowCheckBoxAnimation = false;
            this.check.AllowCheckmarkAnimation = true;
            this.check.AllowOnHoverStates = true;
            this.check.AutoCheck = true;
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.check.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.check.BorderRadius = 12;
            this.check.Checked = true;
            this.check.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.CustomCheckmarkImage = null;
            this.check.Location = new System.Drawing.Point(13, 15);
            this.check.MinimumSize = new System.Drawing.Size(17, 17);
            this.check.Name = "check";
            this.check.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.check.OnCheck.BorderRadius = 12;
            this.check.OnCheck.BorderThickness = 2;
            this.check.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.check.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.check.OnCheck.CheckmarkThickness = 2;
            this.check.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.check.OnDisable.BorderRadius = 12;
            this.check.OnDisable.BorderThickness = 2;
            this.check.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.check.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.check.OnDisable.CheckmarkThickness = 2;
            this.check.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.check.OnHoverChecked.BorderRadius = 12;
            this.check.OnHoverChecked.BorderThickness = 2;
            this.check.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.check.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.check.OnHoverChecked.CheckmarkThickness = 2;
            this.check.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.check.OnHoverUnchecked.BorderRadius = 12;
            this.check.OnHoverUnchecked.BorderThickness = 1;
            this.check.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.check.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.check.OnUncheck.BorderRadius = 12;
            this.check.OnUncheck.BorderThickness = 1;
            this.check.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.check.Size = new System.Drawing.Size(21, 21);
            this.check.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.check.TabIndex = 0;
            this.check.ThreeState = false;
            this.check.ToolTipText = null;
            this.check.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.check_CheckedChanged);
            // 
            // btnModify
            // 
            this.btnModify.ActiveImage = null;
            this.btnModify.AllowAnimations = true;
            this.btnModify.AllowBuffering = false;
            this.btnModify.AllowToggling = false;
            this.btnModify.AllowZooming = true;
            this.btnModify.AllowZoomingOnFocus = false;
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModify.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnModify.ErrorImage")));
            this.btnModify.FadeWhenInactive = false;
            this.btnModify.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageActive = null;
            this.btnModify.ImageLocation = null;
            this.btnModify.ImageMargin = 20;
            this.btnModify.ImageSize = new System.Drawing.Size(32, 27);
            this.btnModify.ImageZoomSize = new System.Drawing.Size(52, 47);
            this.btnModify.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnModify.InitialImage")));
            this.btnModify.Location = new System.Drawing.Point(389, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Rotation = 0;
            this.btnModify.ShowActiveImage = true;
            this.btnModify.ShowCursorChanges = true;
            this.btnModify.ShowImageBorders = true;
            this.btnModify.ShowSizeMarkers = false;
            this.btnModify.Size = new System.Drawing.Size(52, 47);
            this.btnModify.TabIndex = 3;
            this.btnModify.ToolTipText = "";
            this.btnModify.WaitOnLoad = false;
            this.btnModify.Zoom = 20;
            this.btnModify.ZoomSpeed = 10;
            this.btnModify.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.check);
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(499, 55);
            this.Load += new System.EventHandler(this.todo_item_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuCheckBox check;
        private Bunifu.UI.WinForms.BunifuLabel lbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuImageButton btnDelete;
        private Bunifu.UI.WinForms.BunifuImageButton btnModify;
    }
}
