
namespace Clinic_Mang_Sys.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject1 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject2 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject3 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject4 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject4 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject5 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject5 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Kimtoo.ValidationProvider.ValidationObject validationObject6 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject6 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Kimtoo.ValidationProvider.ValidationObject validationObject7 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject7 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.BindingProvider.BindingProvider.BindingObject bindingObject8 = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject8 = new Kimtoo.ValidationProvider.ValidationObject();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bindingProvider1 = new Kimtoo.BindingProvider.BindingProvider();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.imageSun_light = new System.Windows.Forms.PictureBox();
            this.imageMoon_light = new System.Windows.Forms.PictureBox();
            this.imageSun_dark = new System.Windows.Forms.PictureBox();
            this.imageMoon_dark = new System.Windows.Forms.PictureBox();
            this.btnArabic = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEnglish = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.validationProvider1 = new Kimtoo.ValidationProvider.ValidationProvider();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.btnToggleDark_LightMode = new MohamedToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSun_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMoon_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSun_dark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMoon_dark)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuAppBar1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuAppBar1.Icon")));
            bindingObject1.Data = "";
            bindingObject1.Property = "Text";
            bindingObject1.TwoWay = true;
            this.bindingProvider1.SetLink(this.bunifuAppBar1, bindingObject1);
            validationObject1.CustomErrorMessage = "";
            validationObject1.Optional = false;
            validationObject1.PropertyName = "Text";
            validationObject1.Regex = null;
            validationObject1.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.bunifuAppBar1, validationObject1);
            this.bunifuAppBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(700, 46);
            this.bunifuAppBar1.TabIndex = 2;
            this.bunifuAppBar1.Title = "Settings";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // imageSun_light
            // 
            this.imageSun_light.Image = ((System.Drawing.Image)(resources.GetObject("imageSun_light.Image")));
            bindingObject2.Data = "";
            bindingObject2.Property = "Text";
            bindingObject2.TwoWay = true;
            this.bindingProvider1.SetLink(this.imageSun_light, bindingObject2);
            validationObject2.CustomErrorMessage = "";
            validationObject2.Optional = false;
            validationObject2.PropertyName = "Text";
            validationObject2.Regex = null;
            validationObject2.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.imageSun_light, validationObject2);
            this.imageSun_light.Location = new System.Drawing.Point(510, 74);
            this.imageSun_light.Name = "imageSun_light";
            this.imageSun_light.Size = new System.Drawing.Size(41, 48);
            this.imageSun_light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSun_light.TabIndex = 4;
            this.imageSun_light.TabStop = false;
            // 
            // imageMoon_light
            // 
            this.imageMoon_light.Image = ((System.Drawing.Image)(resources.GetObject("imageMoon_light.Image")));
            bindingObject3.Data = "";
            bindingObject3.Property = "Text";
            bindingObject3.TwoWay = true;
            this.bindingProvider1.SetLink(this.imageMoon_light, bindingObject3);
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = null;
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.imageMoon_light, validationObject3);
            this.imageMoon_light.Location = new System.Drawing.Point(627, 75);
            this.imageMoon_light.Name = "imageMoon_light";
            this.imageMoon_light.Size = new System.Drawing.Size(41, 48);
            this.imageMoon_light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMoon_light.TabIndex = 5;
            this.imageMoon_light.TabStop = false;
            // 
            // imageSun_dark
            // 
            this.imageSun_dark.Image = ((System.Drawing.Image)(resources.GetObject("imageSun_dark.Image")));
            bindingObject4.Data = "";
            bindingObject4.Property = "Text";
            bindingObject4.TwoWay = true;
            this.bindingProvider1.SetLink(this.imageSun_dark, bindingObject4);
            validationObject4.CustomErrorMessage = "";
            validationObject4.Optional = false;
            validationObject4.PropertyName = "Text";
            validationObject4.Regex = null;
            validationObject4.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.imageSun_dark, validationObject4);
            this.imageSun_dark.Location = new System.Drawing.Point(510, 74);
            this.imageSun_dark.Name = "imageSun_dark";
            this.imageSun_dark.Size = new System.Drawing.Size(41, 48);
            this.imageSun_dark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSun_dark.TabIndex = 6;
            this.imageSun_dark.TabStop = false;
            this.imageSun_dark.Visible = false;
            // 
            // imageMoon_dark
            // 
            this.imageMoon_dark.Image = ((System.Drawing.Image)(resources.GetObject("imageMoon_dark.Image")));
            bindingObject5.Data = "";
            bindingObject5.Property = "Text";
            bindingObject5.TwoWay = true;
            this.bindingProvider1.SetLink(this.imageMoon_dark, bindingObject5);
            validationObject5.CustomErrorMessage = "";
            validationObject5.Optional = false;
            validationObject5.PropertyName = "Text";
            validationObject5.Regex = null;
            validationObject5.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.imageMoon_dark, validationObject5);
            this.imageMoon_dark.Location = new System.Drawing.Point(627, 75);
            this.imageMoon_dark.Name = "imageMoon_dark";
            this.imageMoon_dark.Size = new System.Drawing.Size(41, 48);
            this.imageMoon_dark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageMoon_dark.TabIndex = 7;
            this.imageMoon_dark.TabStop = false;
            this.imageMoon_dark.Visible = false;
            // 
            // btnArabic
            // 
            this.btnArabic.AllowAnimations = true;
            this.btnArabic.AllowMouseEffects = true;
            this.btnArabic.AllowToggling = false;
            this.btnArabic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArabic.AnimationSpeed = 200;
            this.btnArabic.AutoGenerateColors = false;
            this.btnArabic.AutoRoundBorders = false;
            this.btnArabic.AutoSizeLeftIcon = true;
            this.btnArabic.AutoSizeRightIcon = true;
            this.btnArabic.BackColor = System.Drawing.Color.Transparent;
            this.btnArabic.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnArabic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArabic.BackgroundImage")));
            this.btnArabic.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArabic.ButtonText = "Arabic";
            this.btnArabic.ButtonTextMarginLeft = 0;
            this.btnArabic.ColorContrastOnClick = 45;
            this.btnArabic.ColorContrastOnHover = 45;
            this.btnArabic.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnArabic.CustomizableEdges = borderEdges1;
            this.btnArabic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArabic.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnArabic.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnArabic.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnArabic.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnArabic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArabic.ForeColor = System.Drawing.Color.White;
            this.btnArabic.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArabic.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnArabic.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnArabic.IconMarginLeft = 11;
            this.btnArabic.IconPadding = 10;
            this.btnArabic.IconRightAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArabic.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnArabic.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnArabic.IconSize = 25;
            this.btnArabic.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnArabic.IdleBorderRadius = 35;
            this.btnArabic.IdleBorderThickness = 1;
            this.btnArabic.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnArabic.IdleIconLeftImage = null;
            this.btnArabic.IdleIconRightImage = null;
            this.btnArabic.IndicateFocus = false;
            validationObject6.CustomErrorMessage = "";
            validationObject6.Optional = false;
            validationObject6.PropertyName = "Text";
            validationObject6.Regex = null;
            validationObject6.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnArabic, validationObject6);
            bindingObject6.Data = "";
            bindingObject6.Property = "Text";
            bindingObject6.TwoWay = true;
            this.bindingProvider1.SetLink(this.btnArabic, bindingObject6);
            this.btnArabic.Location = new System.Drawing.Point(435, 297);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnArabic.OnDisabledState.BorderRadius = 35;
            this.btnArabic.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArabic.OnDisabledState.BorderThickness = 1;
            this.btnArabic.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnArabic.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnArabic.OnDisabledState.IconLeftImage = null;
            this.btnArabic.OnDisabledState.IconRightImage = null;
            this.btnArabic.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnArabic.onHoverState.BorderRadius = 35;
            this.btnArabic.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArabic.onHoverState.BorderThickness = 1;
            this.btnArabic.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnArabic.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnArabic.onHoverState.IconLeftImage = null;
            this.btnArabic.onHoverState.IconRightImage = null;
            this.btnArabic.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnArabic.OnIdleState.BorderRadius = 35;
            this.btnArabic.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArabic.OnIdleState.BorderThickness = 1;
            this.btnArabic.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnArabic.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnArabic.OnIdleState.IconLeftImage = null;
            this.btnArabic.OnIdleState.IconRightImage = null;
            this.btnArabic.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnArabic.OnPressedState.BorderRadius = 35;
            this.btnArabic.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArabic.OnPressedState.BorderThickness = 1;
            this.btnArabic.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnArabic.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnArabic.OnPressedState.IconLeftImage = null;
            this.btnArabic.OnPressedState.IconRightImage = null;
            this.btnArabic.Size = new System.Drawing.Size(116, 39);
            this.btnArabic.TabIndex = 43;
            this.btnArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArabic.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnArabic.TextMarginLeft = 0;
            this.btnArabic.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnArabic.UseDefaultRadiusAndThickness = true;
            this.btnArabic.Click += new System.EventHandler(this.btnArabic_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.AllowAnimations = true;
            this.btnEnglish.AllowMouseEffects = true;
            this.btnEnglish.AllowToggling = false;
            this.btnEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnglish.AnimationSpeed = 200;
            this.btnEnglish.AutoGenerateColors = false;
            this.btnEnglish.AutoRoundBorders = false;
            this.btnEnglish.AutoSizeLeftIcon = true;
            this.btnEnglish.AutoSizeRightIcon = true;
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnglish.BackgroundImage")));
            this.btnEnglish.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnglish.ButtonText = "English";
            this.btnEnglish.ButtonTextMarginLeft = 0;
            this.btnEnglish.ColorContrastOnClick = 45;
            this.btnEnglish.ColorContrastOnHover = 45;
            this.btnEnglish.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEnglish.CustomizableEdges = borderEdges2;
            this.btnEnglish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnglish.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnglish.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnglish.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnglish.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEnglish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnglish.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnglish.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEnglish.IconMarginLeft = 11;
            this.btnEnglish.IconPadding = 10;
            this.btnEnglish.IconRightAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnglish.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnglish.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEnglish.IconSize = 25;
            this.btnEnglish.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnEnglish.IdleBorderRadius = 35;
            this.btnEnglish.IdleBorderThickness = 1;
            this.btnEnglish.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnEnglish.IdleIconLeftImage = null;
            this.btnEnglish.IdleIconRightImage = null;
            this.btnEnglish.IndicateFocus = false;
            validationObject7.CustomErrorMessage = "";
            validationObject7.Optional = false;
            validationObject7.PropertyName = "Text";
            validationObject7.Regex = null;
            validationObject7.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnEnglish, validationObject7);
            bindingObject7.Data = "";
            bindingObject7.Property = "Text";
            bindingObject7.TwoWay = true;
            this.bindingProvider1.SetLink(this.btnEnglish, bindingObject7);
            this.btnEnglish.Location = new System.Drawing.Point(572, 297);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnglish.OnDisabledState.BorderRadius = 35;
            this.btnEnglish.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnglish.OnDisabledState.BorderThickness = 1;
            this.btnEnglish.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnglish.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnglish.OnDisabledState.IconLeftImage = null;
            this.btnEnglish.OnDisabledState.IconRightImage = null;
            this.btnEnglish.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEnglish.onHoverState.BorderRadius = 35;
            this.btnEnglish.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnglish.onHoverState.BorderThickness = 1;
            this.btnEnglish.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnEnglish.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.onHoverState.IconLeftImage = null;
            this.btnEnglish.onHoverState.IconRightImage = null;
            this.btnEnglish.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.btnEnglish.OnIdleState.BorderRadius = 35;
            this.btnEnglish.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnglish.OnIdleState.BorderThickness = 1;
            this.btnEnglish.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnEnglish.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.OnIdleState.IconLeftImage = null;
            this.btnEnglish.OnIdleState.IconRightImage = null;
            this.btnEnglish.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnglish.OnPressedState.BorderRadius = 35;
            this.btnEnglish.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnglish.OnPressedState.BorderThickness = 1;
            this.btnEnglish.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnglish.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.OnPressedState.IconLeftImage = null;
            this.btnEnglish.OnPressedState.IconRightImage = null;
            this.btnEnglish.Size = new System.Drawing.Size(116, 39);
            this.btnEnglish.TabIndex = 44;
            this.btnEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnglish.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnglish.TextMarginLeft = 0;
            this.btnEnglish.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEnglish.UseDefaultRadiusAndThickness = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // validationProvider1
            // 
            this.validationProvider1.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // btnToggleDark_LightMode
            // 
            this.btnToggleDark_LightMode.AutoSize = true;
            bindingObject8.Data = "";
            bindingObject8.Property = "Text";
            bindingObject8.TwoWay = true;
            this.bindingProvider1.SetLink(this.btnToggleDark_LightMode, bindingObject8);
            validationObject8.CustomErrorMessage = "";
            validationObject8.Optional = false;
            validationObject8.PropertyName = "Text";
            validationObject8.Regex = null;
            validationObject8.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnToggleDark_LightMode, validationObject8);
            this.btnToggleDark_LightMode.Location = new System.Drawing.Point(559, 84);
            this.btnToggleDark_LightMode.MinimumSize = new System.Drawing.Size(60, 30);
            this.btnToggleDark_LightMode.Name = "btnToggleDark_LightMode";
            this.btnToggleDark_LightMode.OffBackColor = System.Drawing.Color.Gray;
            this.btnToggleDark_LightMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnToggleDark_LightMode.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnToggleDark_LightMode.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggleDark_LightMode.Size = new System.Drawing.Size(60, 30);
            this.btnToggleDark_LightMode.TabIndex = 3;
            this.btnToggleDark_LightMode.UseVisualStyleBackColor = true;
            this.btnToggleDark_LightMode.CheckedChanged += new System.EventHandler(this.btnToggleDark_LightMode_CheckedChanged);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 680);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnArabic);
            this.Controls.Add(this.imageMoon_dark);
            this.Controls.Add(this.imageSun_dark);
            this.Controls.Add(this.imageMoon_light);
            this.Controls.Add(this.imageSun_light);
            this.Controls.Add(this.btnToggleDark_LightMode);
            this.Controls.Add(this.bunifuAppBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 680);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.imageSun_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMoon_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSun_dark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMoon_dark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Kimtoo.BindingProvider.BindingProvider bindingProvider1;
        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
        private Kimtoo.ValidationProvider.ValidationProvider validationProvider1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.PictureBox imageMoon_dark;
        private System.Windows.Forms.PictureBox imageSun_dark;
        private System.Windows.Forms.PictureBox imageMoon_light;
        private System.Windows.Forms.PictureBox imageSun_light;
        private MohamedToggleButton btnToggleDark_LightMode;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnglish;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnArabic;
    }
}