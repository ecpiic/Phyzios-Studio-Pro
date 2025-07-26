using System.Windows.Forms;

namespace WindowsViewer
{
    public partial class Form1 : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToSavedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToLocalAndWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitPhyziosStudioProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSidePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brigAllToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHYZIOSStudioProHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPhyziosStudioProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMovieFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.radioControl = new System.Windows.Forms.RadioButton();
            this.radioToolAxis = new System.Windows.Forms.RadioButton();
            this.radioLink = new System.Windows.Forms.RadioButton();
            this.radioChgColor = new System.Windows.Forms.RadioButton();
            this.radioMarker = new System.Windows.Forms.RadioButton();
            this.radioSelect = new System.Windows.Forms.RadioButton();
            this.radioSlice = new System.Windows.Forms.RadioButton();
            this.radioArrow = new System.Windows.Forms.RadioButton();
            this.radioSpuit = new System.Windows.Forms.RadioButton();
            this.radioReplace = new System.Windows.Forms.RadioButton();
            this.radioEraser = new System.Windows.Forms.RadioButton();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.radioBucket = new System.Windows.Forms.RadioButton();
            this.radioShape = new System.Windows.Forms.RadioButton();
            this.radioPencil = new System.Windows.Forms.RadioButton();
            this.radioBrush = new System.Windows.Forms.RadioButton();
            this.groupBoxScene = new System.Windows.Forms.GroupBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.trackBarAlpha = new System.Windows.Forms.TrackBar();
            this.trackBarPouring = new System.Windows.Forms.TrackBar();
            this.checkBoxPouring = new System.Windows.Forms.CheckBox();
            this.trackBarGravity = new System.Windows.Forms.TrackBar();
            this.checkBoxGravity = new System.Windows.Forms.CheckBox();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxSplash = new System.Windows.Forms.CheckBox();
            this.checkBoxDrain = new System.Windows.Forms.CheckBox();
            this.checkBoxPause = new System.Windows.Forms.CheckBox();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.tabControlMaterials = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.radioLight = new System.Windows.Forms.RadioButton();
            this.radioBlank0 = new System.Windows.Forms.RadioButton();
            this.radioDense = new System.Windows.Forms.RadioButton();
            this.radioPowder = new System.Windows.Forms.RadioButton();
            this.radioAqua = new System.Windows.Forms.RadioButton();
            this.radioRice = new System.Windows.Forms.RadioButton();
            this.radioOil = new System.Windows.Forms.RadioButton();
            this.radioGas = new System.Windows.Forms.RadioButton();
            this.radioUsers = new System.Windows.Forms.RadioButton();
            this.radioVisco = new System.Windows.Forms.RadioButton();
            this.radioFuel = new System.Windows.Forms.RadioButton();
            this.radioBrittle = new System.Windows.Forms.RadioButton();
            this.radioTensil = new System.Windows.Forms.RadioButton();
            this.radioJet = new System.Windows.Forms.RadioButton();
            this.radioFire = new System.Windows.Forms.RadioButton();
            this.radioZombie = new System.Windows.Forms.RadioButton();
            this.radioMochi = new System.Windows.Forms.RadioButton();
            this.radioWall = new System.Windows.Forms.RadioButton();
            this.radioHot = new System.Windows.Forms.RadioButton();
            this.radioRigid = new System.Windows.Forms.RadioButton();
            this.radioErastic = new System.Windows.Forms.RadioButton();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioCold = new System.Windows.Forms.RadioButton();
            this.radioAxis = new System.Windows.Forms.RadioButton();
            this.radioString = new System.Windows.Forms.RadioButton();
            this.radioFlow = new System.Windows.Forms.RadioButton();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.NaturalButton = new System.Windows.Forms.CheckBox();
            this.NoneButton = new System.Windows.Forms.CheckBox();
            this.JoinableButton = new System.Windows.Forms.CheckBox();
            this.checkZombie = new System.Windows.Forms.CheckBox();
            this.SelectedButton = new System.Windows.Forms.CheckBox();
            this.ReservedButton = new System.Windows.Forms.CheckBox();
            this.TexturedButton = new System.Windows.Forms.CheckBox();
            this.checkVisco = new System.Windows.Forms.CheckBox();
            this.StorableButton = new System.Windows.Forms.CheckBox();
            this.AirButton = new System.Windows.Forms.CheckBox();
            this.checkWall = new System.Windows.Forms.CheckBox();
            this.JetButton = new System.Windows.Forms.CheckBox();
            this.checkWater = new System.Windows.Forms.CheckBox();
            this.checkSolid = new System.Windows.Forms.CheckBox();
            this.checkString = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkLink = new System.Windows.Forms.CheckBox();
            this.checkElastic = new System.Windows.Forms.CheckBox();
            this.checkBrittle = new System.Windows.Forms.CheckBox();
            this.checkUsers = new System.Windows.Forms.CheckBox();
            this.checkAxis = new System.Windows.Forms.CheckBox();
            this.checkMochi = new System.Windows.Forms.CheckBox();
            this.checkFuel = new System.Windows.Forms.CheckBox();
            this.checkHot = new System.Windows.Forms.CheckBox();
            this.checkOut = new System.Windows.Forms.CheckBox();
            this.checkFlow = new System.Windows.Forms.CheckBox();
            this.checkCold = new System.Windows.Forms.CheckBox();
            this.checkRice = new System.Windows.Forms.CheckBox();
            this.checkTensil = new System.Windows.Forms.CheckBox();
            this.checkLight = new System.Windows.Forms.CheckBox();
            this.checkHeavy = new System.Windows.Forms.CheckBox();
            this.checkPowder = new System.Windows.Forms.CheckBox();
            this.checkGas = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxGraphical = new System.Windows.Forms.GroupBox();
            this.buttonUnloadWatermark = new System.Windows.Forms.Button();
            this.buttonWatermark = new System.Windows.Forms.Button();
            this.buttonUnloadBubble = new System.Windows.Forms.Button();
            this.buttonBubbleTexture = new System.Windows.Forms.Button();
            this.buttonUnloadSplash = new System.Windows.Forms.Button();
            this.buttonSplashTexture = new System.Windows.Forms.Button();
            this.buttonUnloadFire = new System.Windows.Forms.Button();
            this.buttonFireTexture = new System.Windows.Forms.Button();
            this.buttonUnloadBack = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonUnloadFore = new System.Windows.Forms.Button();
            this.buttonForeground = new System.Windows.Forms.Button();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuMain.SuspendLayout();
            this.groupBoxTool.SuspendLayout();
            this.groupBoxScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPouring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGravity)).BeginInit();
            this.groupBoxBasic.SuspendLayout();
            this.tabControlMaterials.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            this.tabPageCustom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxGraphical.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.AutoSize = false;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.engineToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.hToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuMain.Size = new System.Drawing.Size(1061, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.revertToSavedToolStripMenuItem,
            this.saveToLocalAndWebToolStripMenuItem,
            this.quitPhyziosStudioProToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem1_DropDownOpened);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // revertToSavedToolStripMenuItem
            // 
            this.revertToSavedToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.revertToSavedToolStripMenuItem.Name = "revertToSavedToolStripMenuItem";
            this.revertToSavedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.revertToSavedToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.revertToSavedToolStripMenuItem.Text = "Revert to Saved";
            this.revertToSavedToolStripMenuItem.Click += new System.EventHandler(this.revertToSavedToolStripMenuItem_Click);
            // 
            // saveToLocalAndWebToolStripMenuItem
            // 
            this.saveToLocalAndWebToolStripMenuItem.Name = "saveToLocalAndWebToolStripMenuItem";
            this.saveToLocalAndWebToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToLocalAndWebToolStripMenuItem.Text = "Save to Local and Web";
            this.saveToLocalAndWebToolStripMenuItem.Visible = false;
            this.saveToLocalAndWebToolStripMenuItem.Click += new System.EventHandler(this.saveToLocalAndWebToolStripMenuItem_Click);
            // 
            // quitPhyziosStudioProToolStripMenuItem
            // 
            this.quitPhyziosStudioProToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quitPhyziosStudioProToolStripMenuItem.Name = "quitPhyziosStudioProToolStripMenuItem";
            this.quitPhyziosStudioProToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitPhyziosStudioProToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.quitPhyziosStudioProToolStripMenuItem.Text = "Quit";
            this.quitPhyziosStudioProToolStripMenuItem.Click += new System.EventHandler(this.quitPhyziosStudioProToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.editToolStripMenuItem_DropDownOpened);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // engineToolStripMenuItem
            // 
            this.engineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieCapturingToolStripMenuItem,
            this.playSoundToolStripMenuItem,
            this.gCCollectToolStripMenuItem});
            this.engineToolStripMenuItem.Name = "engineToolStripMenuItem";
            this.engineToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.engineToolStripMenuItem.Text = "Engine";
            this.engineToolStripMenuItem.DropDownOpened += new System.EventHandler(this.engineToolStripMenuItem_DropDownOpened);
            // 
            // movieCapturingToolStripMenuItem
            // 
            this.movieCapturingToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.movieCapturingToolStripMenuItem.Name = "movieCapturingToolStripMenuItem";
            this.movieCapturingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.movieCapturingToolStripMenuItem.Text = "Movie Capturing";
            this.movieCapturingToolStripMenuItem.Visible = false;
            this.movieCapturingToolStripMenuItem.Click += new System.EventHandler(this.movieCapturingToolStripMenuItem_Click);
            // 
            // playSoundToolStripMenuItem
            // 
            this.playSoundToolStripMenuItem.Name = "playSoundToolStripMenuItem";
            this.playSoundToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.playSoundToolStripMenuItem.Text = "Play Sound";
            this.playSoundToolStripMenuItem.Click += new System.EventHandler(this.playSoundToolStripMenuItem_Click);
            // 
            // gCCollectToolStripMenuItem
            // 
            this.gCCollectToolStripMenuItem.Name = "gCCollectToolStripMenuItem";
            this.gCCollectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gCCollectToolStripMenuItem.Text = "GC Collect";
            this.gCCollectToolStripMenuItem.Click += new System.EventHandler(this.gCCollectToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.browserToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.hideSidePanelToolStripMenuItem,
            this.brigAllToFrontToolStripMenuItem,
            this.topmostToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.browserToolStripMenuItem.Text = "Browser";
            this.browserToolStripMenuItem.Click += new System.EventHandler(this.browserToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // hideSidePanelToolStripMenuItem
            // 
            this.hideSidePanelToolStripMenuItem.CheckOnClick = true;
            this.hideSidePanelToolStripMenuItem.Name = "hideSidePanelToolStripMenuItem";
            this.hideSidePanelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.hideSidePanelToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.hideSidePanelToolStripMenuItem.Text = "Hide side panel";
            this.hideSidePanelToolStripMenuItem.Click += new System.EventHandler(this.hideSidePanelToolStripMenuItem_Click);
            // 
            // brigAllToFrontToolStripMenuItem
            // 
            this.brigAllToFrontToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.brigAllToFrontToolStripMenuItem.Name = "brigAllToFrontToolStripMenuItem";
            this.brigAllToFrontToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.brigAllToFrontToolStripMenuItem.Text = "Bring All to Front";
            this.brigAllToFrontToolStripMenuItem.Click += new System.EventHandler(this.brigAllToFrontToolStripMenuItem_Click);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Topmost_CheckChanged);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHYZIOSStudioProHelpToolStripMenuItem,
            this.aboutPhyziosStudioProToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.hToolStripMenuItem.Text = "Help";
            // 
            // pHYZIOSStudioProHelpToolStripMenuItem
            // 
            this.pHYZIOSStudioProHelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pHYZIOSStudioProHelpToolStripMenuItem.Name = "pHYZIOSStudioProHelpToolStripMenuItem";
            this.pHYZIOSStudioProHelpToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pHYZIOSStudioProHelpToolStripMenuItem.Text = "PHYZIOS Studio Pro Help";
            this.pHYZIOSStudioProHelpToolStripMenuItem.Click += new System.EventHandler(this.pHYZIOSStudioProHelpToolStripMenuItem_Click);
            // 
            // aboutPhyziosStudioProToolStripMenuItem
            // 
            this.aboutPhyziosStudioProToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutPhyziosStudioProToolStripMenuItem.Name = "aboutPhyziosStudioProToolStripMenuItem";
            this.aboutPhyziosStudioProToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutPhyziosStudioProToolStripMenuItem.Text = "About PhyziosStudioPro";
            this.aboutPhyziosStudioProToolStripMenuItem.Click += new System.EventHandler(this.aboutPhyziosStudioProToolStripMenuItem_Click);
            // 
            // saveMovieFile
            // 
            this.saveMovieFile.DefaultExt = "avi";
            this.saveMovieFile.Filter = "AVI file|*.avi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 700);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxTool.Controls.Add(this.radioControl);
            this.groupBoxTool.Controls.Add(this.radioToolAxis);
            this.groupBoxTool.Controls.Add(this.radioLink);
            this.groupBoxTool.Controls.Add(this.radioChgColor);
            this.groupBoxTool.Controls.Add(this.radioMarker);
            this.groupBoxTool.Controls.Add(this.radioSelect);
            this.groupBoxTool.Controls.Add(this.radioSlice);
            this.groupBoxTool.Controls.Add(this.radioArrow);
            this.groupBoxTool.Controls.Add(this.radioSpuit);
            this.groupBoxTool.Controls.Add(this.radioReplace);
            this.groupBoxTool.Controls.Add(this.radioEraser);
            this.groupBoxTool.Controls.Add(this.radioMove);
            this.groupBoxTool.Controls.Add(this.radioBucket);
            this.groupBoxTool.Controls.Add(this.radioShape);
            this.groupBoxTool.Controls.Add(this.radioPencil);
            this.groupBoxTool.Controls.Add(this.radioBrush);
            this.groupBoxTool.Location = new System.Drawing.Point(5, 378);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(239, 123);
            this.groupBoxTool.TabIndex = 52;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "Tool";
            // 
            // radioControl
            // 
            this.radioControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioControl.Location = new System.Drawing.Point(176, 94);
            this.radioControl.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioControl.Name = "radioControl";
            this.radioControl.Size = new System.Drawing.Size(53, 23);
            this.radioControl.TabIndex = 42;
            this.radioControl.Text = "Control";
            this.radioControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioControl.UseVisualStyleBackColor = true;
            this.radioControl.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioToolAxis
            // 
            this.radioToolAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToolAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioToolAxis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioToolAxis.Location = new System.Drawing.Point(120, 94);
            this.radioToolAxis.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioToolAxis.Name = "radioToolAxis";
            this.radioToolAxis.Size = new System.Drawing.Size(53, 23);
            this.radioToolAxis.TabIndex = 41;
            this.radioToolAxis.Text = "Axis";
            this.radioToolAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToolAxis.UseVisualStyleBackColor = true;
            this.radioToolAxis.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioLink
            // 
            this.radioLink.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioLink.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioLink.Location = new System.Drawing.Point(64, 94);
            this.radioLink.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(53, 23);
            this.radioLink.TabIndex = 40;
            this.radioLink.Text = "Link";
            this.radioLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioChgColor
            // 
            this.radioChgColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioChgColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioChgColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioChgColor.Location = new System.Drawing.Point(120, 68);
            this.radioChgColor.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioChgColor.Name = "radioChgColor";
            this.radioChgColor.Size = new System.Drawing.Size(53, 23);
            this.radioChgColor.TabIndex = 39;
            this.radioChgColor.Text = "Color";
            this.radioChgColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioChgColor.UseVisualStyleBackColor = true;
            this.radioChgColor.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioMarker
            // 
            this.radioMarker.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMarker.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioMarker.Location = new System.Drawing.Point(176, 68);
            this.radioMarker.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioMarker.Name = "radioMarker";
            this.radioMarker.Size = new System.Drawing.Size(53, 23);
            this.radioMarker.TabIndex = 38;
            this.radioMarker.Text = "Marker";
            this.radioMarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMarker.UseVisualStyleBackColor = true;
            this.radioMarker.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioSelect
            // 
            this.radioSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioSelect.Location = new System.Drawing.Point(9, 94);
            this.radioSelect.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioSelect.Name = "radioSelect";
            this.radioSelect.Size = new System.Drawing.Size(53, 23);
            this.radioSelect.TabIndex = 37;
            this.radioSelect.Text = "Select";
            this.radioSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSelect.UseVisualStyleBackColor = true;
            this.radioSelect.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioSlice
            // 
            this.radioSlice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSlice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSlice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioSlice.Location = new System.Drawing.Point(64, 68);
            this.radioSlice.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioSlice.Name = "radioSlice";
            this.radioSlice.Size = new System.Drawing.Size(53, 23);
            this.radioSlice.TabIndex = 36;
            this.radioSlice.Text = "Slice";
            this.radioSlice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSlice.UseVisualStyleBackColor = true;
            this.radioSlice.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioArrow
            // 
            this.radioArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioArrow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioArrow.Location = new System.Drawing.Point(9, 68);
            this.radioArrow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioArrow.Name = "radioArrow";
            this.radioArrow.Size = new System.Drawing.Size(53, 23);
            this.radioArrow.TabIndex = 35;
            this.radioArrow.Text = "Arrow";
            this.radioArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioArrow.UseVisualStyleBackColor = true;
            this.radioArrow.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioSpuit
            // 
            this.radioSpuit.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioSpuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioSpuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioSpuit.Location = new System.Drawing.Point(176, 42);
            this.radioSpuit.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioSpuit.Name = "radioSpuit";
            this.radioSpuit.Size = new System.Drawing.Size(53, 23);
            this.radioSpuit.TabIndex = 34;
            this.radioSpuit.Text = "Spuit";
            this.radioSpuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSpuit.UseVisualStyleBackColor = true;
            this.radioSpuit.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioReplace
            // 
            this.radioReplace.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioReplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioReplace.Location = new System.Drawing.Point(120, 42);
            this.radioReplace.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioReplace.Name = "radioReplace";
            this.radioReplace.Size = new System.Drawing.Size(53, 23);
            this.radioReplace.TabIndex = 33;
            this.radioReplace.Text = "Replace";
            this.radioReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioReplace.UseVisualStyleBackColor = true;
            this.radioReplace.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioEraser
            // 
            this.radioEraser.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioEraser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioEraser.Location = new System.Drawing.Point(64, 42);
            this.radioEraser.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioEraser.Name = "radioEraser";
            this.radioEraser.Size = new System.Drawing.Size(53, 23);
            this.radioEraser.TabIndex = 32;
            this.radioEraser.Text = "Eraser";
            this.radioEraser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEraser.UseVisualStyleBackColor = true;
            this.radioEraser.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioMove
            // 
            this.radioMove.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioMove.Location = new System.Drawing.Point(9, 42);
            this.radioMove.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(53, 23);
            this.radioMove.TabIndex = 31;
            this.radioMove.Text = "Move";
            this.radioMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMove.UseVisualStyleBackColor = true;
            this.radioMove.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioBucket
            // 
            this.radioBucket.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBucket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBucket.Location = new System.Drawing.Point(176, 16);
            this.radioBucket.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBucket.Name = "radioBucket";
            this.radioBucket.Size = new System.Drawing.Size(53, 23);
            this.radioBucket.TabIndex = 30;
            this.radioBucket.Text = "Bucket";
            this.radioBucket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBucket.UseVisualStyleBackColor = true;
            this.radioBucket.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioShape
            // 
            this.radioShape.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioShape.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioShape.Location = new System.Drawing.Point(120, 16);
            this.radioShape.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioShape.Name = "radioShape";
            this.radioShape.Size = new System.Drawing.Size(53, 23);
            this.radioShape.TabIndex = 29;
            this.radioShape.Text = "Shape";
            this.radioShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioShape.UseVisualStyleBackColor = true;
            this.radioShape.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioPencil
            // 
            this.radioPencil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioPencil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioPencil.Location = new System.Drawing.Point(64, 16);
            this.radioPencil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioPencil.Name = "radioPencil";
            this.radioPencil.Size = new System.Drawing.Size(53, 23);
            this.radioPencil.TabIndex = 28;
            this.radioPencil.Text = "Pencil";
            this.radioPencil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPencil.UseVisualStyleBackColor = true;
            this.radioPencil.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // radioBrush
            // 
            this.radioBrush.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBrush.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBrush.Location = new System.Drawing.Point(9, 16);
            this.radioBrush.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBrush.Name = "radioBrush";
            this.radioBrush.Size = new System.Drawing.Size(53, 23);
            this.radioBrush.TabIndex = 27;
            this.radioBrush.Text = "Brush";
            this.radioBrush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBrush.UseVisualStyleBackColor = true;
            this.radioBrush.CheckedChanged += new System.EventHandler(this.OECToolButton_CheckChanged);
            // 
            // groupBoxScene
            // 
            this.groupBoxScene.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxScene.Controls.Add(this.buttonColor);
            this.groupBoxScene.Controls.Add(this.buttonRedo);
            this.groupBoxScene.Controls.Add(this.buttonUndo);
            this.groupBoxScene.Controls.Add(this.buttonClear);
            this.groupBoxScene.Controls.Add(this.textBoxAlpha);
            this.groupBoxScene.Controls.Add(this.trackBarAlpha);
            this.groupBoxScene.Controls.Add(this.trackBarPouring);
            this.groupBoxScene.Controls.Add(this.checkBoxPouring);
            this.groupBoxScene.Controls.Add(this.trackBarGravity);
            this.groupBoxScene.Controls.Add(this.checkBoxGravity);
            this.groupBoxScene.Controls.Add(this.checkBoxBubble);
            this.groupBoxScene.Controls.Add(this.checkBoxSplash);
            this.groupBoxScene.Controls.Add(this.checkBoxDrain);
            this.groupBoxScene.Controls.Add(this.checkBoxPause);
            this.groupBoxScene.Location = new System.Drawing.Point(5, 238);
            this.groupBoxScene.Name = "groupBoxScene";
            this.groupBoxScene.Size = new System.Drawing.Size(239, 136);
            this.groupBoxScene.TabIndex = 51;
            this.groupBoxScene.TabStop = false;
            this.groupBoxScene.Text = "Scene";
            // 
            // buttonColor
            // 
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonColor.Location = new System.Drawing.Point(176, 108);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(53, 23);
            this.buttonColor.TabIndex = 38;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRedo.Location = new System.Drawing.Point(120, 108);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(53, 23);
            this.buttonRedo.TabIndex = 37;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUndo.Location = new System.Drawing.Point(64, 108);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(53, 23);
            this.buttonUndo.TabIndex = 36;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClear.Location = new System.Drawing.Point(9, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 23);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(10, 85);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(52, 20);
            this.textBoxAlpha.TabIndex = 43;
            // 
            // trackBarAlpha
            // 
            this.trackBarAlpha.AutoSize = false;
            this.trackBarAlpha.Location = new System.Drawing.Point(63, 85);
            this.trackBarAlpha.Maximum = 255;
            this.trackBarAlpha.Name = "trackBarAlpha";
            this.trackBarAlpha.Size = new System.Drawing.Size(162, 25);
            this.trackBarAlpha.TabIndex = 39;
            this.trackBarAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAlpha.Value = 255;
            this.trackBarAlpha.Scroll += new System.EventHandler(this.trackBarAlpha_Scroll);
            // 
            // trackBarPouring
            // 
            this.trackBarPouring.AutoSize = false;
            this.trackBarPouring.Location = new System.Drawing.Point(64, 61);
            this.trackBarPouring.Maximum = 1000;
            this.trackBarPouring.Minimum = 1;
            this.trackBarPouring.Name = "trackBarPouring";
            this.trackBarPouring.Size = new System.Drawing.Size(162, 25);
            this.trackBarPouring.TabIndex = 34;
            this.trackBarPouring.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPouring.Value = 600;
            this.trackBarPouring.ValueChanged += new System.EventHandler(this.trackBarPouring_ValueChanged);
            // 
            // checkBoxPouring
            // 
            this.checkBoxPouring.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxPouring.Location = new System.Drawing.Point(12, 61);
            this.checkBoxPouring.Name = "checkBoxPouring";
            this.checkBoxPouring.Size = new System.Drawing.Size(62, 18);
            this.checkBoxPouring.TabIndex = 33;
            this.checkBoxPouring.Text = "Pouring";
            this.checkBoxPouring.UseVisualStyleBackColor = true;
            this.checkBoxPouring.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxPouring.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // trackBarGravity
            // 
            this.trackBarGravity.AutoSize = false;
            this.trackBarGravity.LargeChange = 1;
            this.trackBarGravity.Location = new System.Drawing.Point(64, 37);
            this.trackBarGravity.Maximum = 1000;
            this.trackBarGravity.Minimum = 1;
            this.trackBarGravity.Name = "trackBarGravity";
            this.trackBarGravity.Size = new System.Drawing.Size(162, 25);
            this.trackBarGravity.TabIndex = 32;
            this.trackBarGravity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGravity.Value = 800;
            this.trackBarGravity.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBarGravity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarMouseUP);
            // 
            // checkBoxGravity
            // 
            this.checkBoxGravity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxGravity.Location = new System.Drawing.Point(12, 37);
            this.checkBoxGravity.Name = "checkBoxGravity";
            this.checkBoxGravity.Size = new System.Drawing.Size(62, 18);
            this.checkBoxGravity.TabIndex = 31;
            this.checkBoxGravity.Text = "Gravity";
            this.checkBoxGravity.UseVisualStyleBackColor = true;
            this.checkBoxGravity.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxGravity.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxBubble.Location = new System.Drawing.Point(178, 13);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(58, 18);
            this.checkBoxBubble.TabIndex = 30;
            this.checkBoxBubble.Text = "Bubble";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            this.checkBoxBubble.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxBubble.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // checkBoxSplash
            // 
            this.checkBoxSplash.AutoSize = true;
            this.checkBoxSplash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxSplash.Location = new System.Drawing.Point(120, 13);
            this.checkBoxSplash.Name = "checkBoxSplash";
            this.checkBoxSplash.Size = new System.Drawing.Size(64, 18);
            this.checkBoxSplash.TabIndex = 29;
            this.checkBoxSplash.Text = "Splash";
            this.checkBoxSplash.UseVisualStyleBackColor = true;
            this.checkBoxSplash.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxSplash.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // checkBoxDrain
            // 
            this.checkBoxDrain.AutoSize = true;
            this.checkBoxDrain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxDrain.Location = new System.Drawing.Point(67, 13);
            this.checkBoxDrain.Name = "checkBoxDrain";
            this.checkBoxDrain.Size = new System.Drawing.Size(57, 18);
            this.checkBoxDrain.TabIndex = 28;
            this.checkBoxDrain.Text = "Drain";
            this.checkBoxDrain.UseVisualStyleBackColor = true;
            this.checkBoxDrain.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxDrain.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // checkBoxPause
            // 
            this.checkBoxPause.AutoSize = true;
            this.checkBoxPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxPause.Location = new System.Drawing.Point(12, 13);
            this.checkBoxPause.Name = "checkBoxPause";
            this.checkBoxPause.Size = new System.Drawing.Size(62, 18);
            this.checkBoxPause.TabIndex = 27;
            this.checkBoxPause.Text = "Pause";
            this.checkBoxPause.UseVisualStyleBackColor = true;
            this.checkBoxPause.CheckedChanged += new System.EventHandler(this.OECCheck_CheckedChanged);
            this.checkBoxPause.Click += new System.EventHandler(this.FocusPanel1);
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxBasic.Controls.Add(this.tabControlMaterials);
            this.groupBoxBasic.Location = new System.Drawing.Point(5, 3);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(239, 234);
            this.groupBoxBasic.TabIndex = 49;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Physics";
            // 
            // tabControlMaterials
            // 
            this.tabControlMaterials.Controls.Add(this.tabPageBasic);
            this.tabControlMaterials.Controls.Add(this.tabPageCustom);
            this.tabControlMaterials.Location = new System.Drawing.Point(3, 15);
            this.tabControlMaterials.Name = "tabControlMaterials";
            this.tabControlMaterials.SelectedIndex = 0;
            this.tabControlMaterials.Size = new System.Drawing.Size(235, 213);
            this.tabControlMaterials.TabIndex = 0;
            this.tabControlMaterials.SelectedIndexChanged += new System.EventHandler(this.tabControlMaterials_SelectedIndexChanged);
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageBasic.Controls.Add(this.radioLight);
            this.tabPageBasic.Controls.Add(this.radioBlank0);
            this.tabPageBasic.Controls.Add(this.radioDense);
            this.tabPageBasic.Controls.Add(this.radioPowder);
            this.tabPageBasic.Controls.Add(this.radioAqua);
            this.tabPageBasic.Controls.Add(this.radioRice);
            this.tabPageBasic.Controls.Add(this.radioOil);
            this.tabPageBasic.Controls.Add(this.radioGas);
            this.tabPageBasic.Controls.Add(this.radioUsers);
            this.tabPageBasic.Controls.Add(this.radioVisco);
            this.tabPageBasic.Controls.Add(this.radioFuel);
            this.tabPageBasic.Controls.Add(this.radioBrittle);
            this.tabPageBasic.Controls.Add(this.radioTensil);
            this.tabPageBasic.Controls.Add(this.radioJet);
            this.tabPageBasic.Controls.Add(this.radioFire);
            this.tabPageBasic.Controls.Add(this.radioZombie);
            this.tabPageBasic.Controls.Add(this.radioMochi);
            this.tabPageBasic.Controls.Add(this.radioWall);
            this.tabPageBasic.Controls.Add(this.radioHot);
            this.tabPageBasic.Controls.Add(this.radioRigid);
            this.tabPageBasic.Controls.Add(this.radioErastic);
            this.tabPageBasic.Controls.Add(this.radioOut);
            this.tabPageBasic.Controls.Add(this.radioCold);
            this.tabPageBasic.Controls.Add(this.radioAxis);
            this.tabPageBasic.Controls.Add(this.radioString);
            this.tabPageBasic.Controls.Add(this.radioFlow);
            this.tabPageBasic.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasic.Size = new System.Drawing.Size(227, 187);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Basic";
            // 
            // radioLight
            // 
            this.radioLight.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioLight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioLight.Location = new System.Drawing.Point(171, 81);
            this.radioLight.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioLight.Name = "radioLight";
            this.radioLight.Size = new System.Drawing.Size(53, 23);
            this.radioLight.TabIndex = 16;
            this.radioLight.Text = "Light";
            this.radioLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioLight.UseVisualStyleBackColor = true;
            this.radioLight.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioBlank0
            // 
            this.radioBlank0.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBlank0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBlank0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBlank0.Location = new System.Drawing.Point(3, 159);
            this.radioBlank0.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBlank0.Name = "radioBlank0";
            this.radioBlank0.Size = new System.Drawing.Size(53, 23);
            this.radioBlank0.TabIndex = 25;
            this.radioBlank0.Text = "Yuki";
            this.radioBlank0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBlank0.UseVisualStyleBackColor = true;
            this.radioBlank0.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioDense
            // 
            this.radioDense.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioDense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioDense.Location = new System.Drawing.Point(115, 81);
            this.radioDense.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioDense.Name = "radioDense";
            this.radioDense.Size = new System.Drawing.Size(53, 23);
            this.radioDense.TabIndex = 15;
            this.radioDense.Text = "Dense";
            this.radioDense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDense.UseVisualStyleBackColor = true;
            this.radioDense.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioPowder
            // 
            this.radioPowder.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPowder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioPowder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioPowder.Location = new System.Drawing.Point(115, 55);
            this.radioPowder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioPowder.Name = "radioPowder";
            this.radioPowder.Size = new System.Drawing.Size(53, 23);
            this.radioPowder.TabIndex = 11;
            this.radioPowder.Text = "Powder";
            this.radioPowder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPowder.UseVisualStyleBackColor = true;
            this.radioPowder.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioAqua
            // 
            this.radioAqua.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioAqua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioAqua.Location = new System.Drawing.Point(115, 3);
            this.radioAqua.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioAqua.Name = "radioAqua";
            this.radioAqua.Size = new System.Drawing.Size(53, 23);
            this.radioAqua.TabIndex = 3;
            this.radioAqua.Text = "Water";
            this.radioAqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioAqua.UseVisualStyleBackColor = true;
            this.radioAqua.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioRice
            // 
            this.radioRice.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioRice.Location = new System.Drawing.Point(59, 55);
            this.radioRice.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioRice.Name = "radioRice";
            this.radioRice.Size = new System.Drawing.Size(53, 23);
            this.radioRice.TabIndex = 10;
            this.radioRice.Text = "Rice";
            this.radioRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioRice.UseVisualStyleBackColor = true;
            this.radioRice.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioOil
            // 
            this.radioOil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioOil.Location = new System.Drawing.Point(59, 159);
            this.radioOil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioOil.Name = "radioOil";
            this.radioOil.Size = new System.Drawing.Size(53, 23);
            this.radioOil.TabIndex = 26;
            this.radioOil.Text = "Oil";
            this.radioOil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioOil.UseVisualStyleBackColor = true;
            this.radioOil.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioGas
            // 
            this.radioGas.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioGas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioGas.Location = new System.Drawing.Point(171, 55);
            this.radioGas.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioGas.Name = "radioGas";
            this.radioGas.Size = new System.Drawing.Size(53, 23);
            this.radioGas.TabIndex = 12;
            this.radioGas.Text = "Gas";
            this.radioGas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioGas.UseVisualStyleBackColor = true;
            this.radioGas.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioUsers
            // 
            this.radioUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioUsers.Location = new System.Drawing.Point(171, 133);
            this.radioUsers.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioUsers.Name = "radioUsers";
            this.radioUsers.Size = new System.Drawing.Size(53, 23);
            this.radioUsers.TabIndex = 24;
            this.radioUsers.Text = "User\'s";
            this.radioUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioVisco
            // 
            this.radioVisco.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioVisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioVisco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioVisco.Location = new System.Drawing.Point(3, 81);
            this.radioVisco.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioVisco.Name = "radioVisco";
            this.radioVisco.Size = new System.Drawing.Size(53, 23);
            this.radioVisco.TabIndex = 13;
            this.radioVisco.Text = "Viscous";
            this.radioVisco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioVisco.UseVisualStyleBackColor = true;
            this.radioVisco.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFuel
            // 
            this.radioFuel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioFuel.Location = new System.Drawing.Point(3, 107);
            this.radioFuel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFuel.Name = "radioFuel";
            this.radioFuel.Size = new System.Drawing.Size(53, 23);
            this.radioFuel.TabIndex = 17;
            this.radioFuel.Text = "Fuel";
            this.radioFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFuel.UseVisualStyleBackColor = true;
            this.radioFuel.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioBrittle
            // 
            this.radioBrittle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioBrittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioBrittle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBrittle.Location = new System.Drawing.Point(115, 29);
            this.radioBrittle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioBrittle.Name = "radioBrittle";
            this.radioBrittle.Size = new System.Drawing.Size(53, 23);
            this.radioBrittle.TabIndex = 7;
            this.radioBrittle.Text = "Brittle";
            this.radioBrittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBrittle.UseVisualStyleBackColor = true;
            this.radioBrittle.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioTensil
            // 
            this.radioTensil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTensil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioTensil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioTensil.Location = new System.Drawing.Point(59, 81);
            this.radioTensil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioTensil.Name = "radioTensil";
            this.radioTensil.Size = new System.Drawing.Size(53, 23);
            this.radioTensil.TabIndex = 14;
            this.radioTensil.Text = "Tensile";
            this.radioTensil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTensil.UseVisualStyleBackColor = true;
            this.radioTensil.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioJet
            // 
            this.radioJet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioJet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioJet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioJet.Location = new System.Drawing.Point(115, 133);
            this.radioJet.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioJet.Name = "radioJet";
            this.radioJet.Size = new System.Drawing.Size(53, 23);
            this.radioJet.TabIndex = 23;
            this.radioJet.Text = "Jet";
            this.radioJet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioJet.UseVisualStyleBackColor = true;
            this.radioJet.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFire
            // 
            this.radioFire.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioFire.Location = new System.Drawing.Point(59, 107);
            this.radioFire.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFire.Name = "radioFire";
            this.radioFire.Size = new System.Drawing.Size(53, 23);
            this.radioFire.TabIndex = 18;
            this.radioFire.Text = "Fire";
            this.radioFire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFire.UseVisualStyleBackColor = true;
            this.radioFire.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioZombie
            // 
            this.radioZombie.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioZombie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioZombie.Location = new System.Drawing.Point(3, 3);
            this.radioZombie.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioZombie.Name = "radioZombie";
            this.radioZombie.Size = new System.Drawing.Size(53, 23);
            this.radioZombie.TabIndex = 1;
            this.radioZombie.Text = "Eraser";
            this.radioZombie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioZombie.UseVisualStyleBackColor = true;
            this.radioZombie.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioMochi
            // 
            this.radioMochi.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMochi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioMochi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioMochi.Location = new System.Drawing.Point(3, 55);
            this.radioMochi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioMochi.Name = "radioMochi";
            this.radioMochi.Size = new System.Drawing.Size(53, 23);
            this.radioMochi.TabIndex = 9;
            this.radioMochi.Text = "Mochi";
            this.radioMochi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMochi.UseVisualStyleBackColor = true;
            this.radioMochi.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioWall
            // 
            this.radioWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioWall.Checked = true;
            this.radioWall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioWall.Location = new System.Drawing.Point(59, 3);
            this.radioWall.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioWall.Name = "radioWall";
            this.radioWall.Size = new System.Drawing.Size(53, 23);
            this.radioWall.TabIndex = 2;
            this.radioWall.TabStop = true;
            this.radioWall.Text = "Wall";
            this.radioWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioWall.UseVisualStyleBackColor = true;
            this.radioWall.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioHot
            // 
            this.radioHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioHot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioHot.Location = new System.Drawing.Point(115, 107);
            this.radioHot.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioHot.Name = "radioHot";
            this.radioHot.Size = new System.Drawing.Size(53, 23);
            this.radioHot.TabIndex = 19;
            this.radioHot.Text = "Heater";
            this.radioHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHot.UseVisualStyleBackColor = true;
            this.radioHot.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioRigid
            // 
            this.radioRigid.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRigid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioRigid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioRigid.Location = new System.Drawing.Point(171, 3);
            this.radioRigid.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioRigid.Name = "radioRigid";
            this.radioRigid.Size = new System.Drawing.Size(53, 23);
            this.radioRigid.TabIndex = 4;
            this.radioRigid.Text = "Rigid";
            this.radioRigid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioRigid.UseVisualStyleBackColor = true;
            this.radioRigid.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioErastic
            // 
            this.radioErastic.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioErastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioErastic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioErastic.Location = new System.Drawing.Point(59, 29);
            this.radioErastic.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioErastic.Name = "radioErastic";
            this.radioErastic.Size = new System.Drawing.Size(53, 23);
            this.radioErastic.TabIndex = 6;
            this.radioErastic.Text = "Elastic";
            this.radioErastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioErastic.UseVisualStyleBackColor = true;
            this.radioErastic.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioOut
            // 
            this.radioOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioOut.Location = new System.Drawing.Point(59, 133);
            this.radioOut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(53, 23);
            this.radioOut.TabIndex = 22;
            this.radioOut.Text = "Outflow";
            this.radioOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioOut.UseVisualStyleBackColor = true;
            this.radioOut.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioCold
            // 
            this.radioCold.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioCold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioCold.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioCold.Location = new System.Drawing.Point(171, 107);
            this.radioCold.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioCold.Name = "radioCold";
            this.radioCold.Size = new System.Drawing.Size(53, 23);
            this.radioCold.TabIndex = 20;
            this.radioCold.Text = "Cooler";
            this.radioCold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCold.UseVisualStyleBackColor = true;
            this.radioCold.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioAxis
            // 
            this.radioAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioAxis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAxis.Location = new System.Drawing.Point(171, 29);
            this.radioAxis.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioAxis.Name = "radioAxis";
            this.radioAxis.Size = new System.Drawing.Size(53, 23);
            this.radioAxis.TabIndex = 8;
            this.radioAxis.Text = "Fulcrum";
            this.radioAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioAxis.UseVisualStyleBackColor = true;
            this.radioAxis.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioString
            // 
            this.radioString.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioString.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioString.Location = new System.Drawing.Point(3, 29);
            this.radioString.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioString.Name = "radioString";
            this.radioString.Size = new System.Drawing.Size(53, 23);
            this.radioString.TabIndex = 5;
            this.radioString.Text = "String";
            this.radioString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioString.UseVisualStyleBackColor = true;
            this.radioString.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // radioFlow
            // 
            this.radioFlow.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioFlow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioFlow.Location = new System.Drawing.Point(3, 133);
            this.radioFlow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.radioFlow.Name = "radioFlow";
            this.radioFlow.Size = new System.Drawing.Size(53, 23);
            this.radioFlow.TabIndex = 21;
            this.radioFlow.Text = "Inflow";
            this.radioFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioFlow.UseVisualStyleBackColor = true;
            this.radioFlow.CheckedChanged += new System.EventHandler(this.Basic_CheckedChanged);
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageCustom.Controls.Add(this.NaturalButton);
            this.tabPageCustom.Controls.Add(this.NoneButton);
            this.tabPageCustom.Controls.Add(this.JoinableButton);
            this.tabPageCustom.Controls.Add(this.checkZombie);
            this.tabPageCustom.Controls.Add(this.SelectedButton);
            this.tabPageCustom.Controls.Add(this.ReservedButton);
            this.tabPageCustom.Controls.Add(this.TexturedButton);
            this.tabPageCustom.Controls.Add(this.checkVisco);
            this.tabPageCustom.Controls.Add(this.StorableButton);
            this.tabPageCustom.Controls.Add(this.AirButton);
            this.tabPageCustom.Controls.Add(this.checkWall);
            this.tabPageCustom.Controls.Add(this.JetButton);
            this.tabPageCustom.Controls.Add(this.checkWater);
            this.tabPageCustom.Controls.Add(this.checkSolid);
            this.tabPageCustom.Controls.Add(this.checkString);
            this.tabPageCustom.Controls.Add(this.checkBox12);
            this.tabPageCustom.Controls.Add(this.checkLink);
            this.tabPageCustom.Controls.Add(this.checkElastic);
            this.tabPageCustom.Controls.Add(this.checkBrittle);
            this.tabPageCustom.Controls.Add(this.checkUsers);
            this.tabPageCustom.Controls.Add(this.checkAxis);
            this.tabPageCustom.Controls.Add(this.checkMochi);
            this.tabPageCustom.Controls.Add(this.checkFuel);
            this.tabPageCustom.Controls.Add(this.checkHot);
            this.tabPageCustom.Controls.Add(this.checkOut);
            this.tabPageCustom.Controls.Add(this.checkFlow);
            this.tabPageCustom.Controls.Add(this.checkCold);
            this.tabPageCustom.Controls.Add(this.checkRice);
            this.tabPageCustom.Controls.Add(this.checkTensil);
            this.tabPageCustom.Controls.Add(this.checkLight);
            this.tabPageCustom.Controls.Add(this.checkHeavy);
            this.tabPageCustom.Controls.Add(this.checkPowder);
            this.tabPageCustom.Controls.Add(this.checkGas);
            this.tabPageCustom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustom.Size = new System.Drawing.Size(227, 187);
            this.tabPageCustom.TabIndex = 1;
            this.tabPageCustom.Text = "Custom";
            // 
            // NaturalButton
            // 
            this.NaturalButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NaturalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NaturalButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NaturalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NaturalButton.Image = global::WindowsViewer.Properties.Resources.Naturaldarkened;
            this.NaturalButton.Location = new System.Drawing.Point(3, 211);
            this.NaturalButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NaturalButton.Name = "NaturalButton";
            this.NaturalButton.Size = new System.Drawing.Size(53, 23);
            this.NaturalButton.TabIndex = 82;
            this.NaturalButton.Text = "Natural";
            this.NaturalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NaturalButton.UseVisualStyleBackColor = true;
            this.NaturalButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // NoneButton
            // 
            this.NoneButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoneButton.BackColor = System.Drawing.Color.White;
            this.NoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NoneButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NoneButton.Location = new System.Drawing.Point(171, 159);
            this.NoneButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(53, 23);
            this.NoneButton.TabIndex = 86;
            this.NoneButton.Text = "Null";
            this.NoneButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoneButton.UseVisualStyleBackColor = false;
            this.NoneButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // JoinableButton
            // 
            this.JoinableButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.JoinableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JoinableButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JoinableButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JoinableButton.Image = global::WindowsViewer.Properties.Resources.Joinable;
            this.JoinableButton.Location = new System.Drawing.Point(171, 185);
            this.JoinableButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.JoinableButton.Name = "JoinableButton";
            this.JoinableButton.Size = new System.Drawing.Size(53, 23);
            this.JoinableButton.TabIndex = 81;
            this.JoinableButton.Text = "Joinable";
            this.JoinableButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JoinableButton.UseVisualStyleBackColor = true;
            this.JoinableButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkZombie
            // 
            this.checkZombie.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkZombie.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkZombie.Image = global::WindowsViewer.Properties.Resources.radioZombie;
            this.checkZombie.Location = new System.Drawing.Point(3, 3);
            this.checkZombie.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkZombie.Name = "checkZombie";
            this.checkZombie.Size = new System.Drawing.Size(53, 23);
            this.checkZombie.TabIndex = 77;
            this.checkZombie.Text = "Eraser";
            this.checkZombie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkZombie.UseVisualStyleBackColor = true;
            this.checkZombie.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // SelectedButton
            // 
            this.SelectedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SelectedButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SelectedButton.Image = global::WindowsViewer.Properties.Resources.Selected;
            this.SelectedButton.Location = new System.Drawing.Point(115, 185);
            this.SelectedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(53, 23);
            this.SelectedButton.TabIndex = 80;
            this.SelectedButton.Text = "Selected";
            this.SelectedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // ReservedButton
            // 
            this.ReservedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ReservedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReservedButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReservedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReservedButton.Image = global::WindowsViewer.Properties.Resources.Reserved;
            this.ReservedButton.Location = new System.Drawing.Point(115, 159);
            this.ReservedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.ReservedButton.Name = "ReservedButton";
            this.ReservedButton.Size = new System.Drawing.Size(53, 23);
            this.ReservedButton.TabIndex = 85;
            this.ReservedButton.Text = "Reserved";
            this.ReservedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReservedButton.UseVisualStyleBackColor = true;
            this.ReservedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // TexturedButton
            // 
            this.TexturedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TexturedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TexturedButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TexturedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TexturedButton.Image = global::WindowsViewer.Properties.Resources.Textured;
            this.TexturedButton.Location = new System.Drawing.Point(59, 185);
            this.TexturedButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TexturedButton.Name = "TexturedButton";
            this.TexturedButton.Size = new System.Drawing.Size(53, 23);
            this.TexturedButton.TabIndex = 79;
            this.TexturedButton.Text = "Textured";
            this.TexturedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TexturedButton.UseVisualStyleBackColor = true;
            this.TexturedButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkVisco
            // 
            this.checkVisco.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkVisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkVisco.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkVisco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkVisco.Image = global::WindowsViewer.Properties.Resources.checkVisco;
            this.checkVisco.Location = new System.Drawing.Point(3, 81);
            this.checkVisco.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkVisco.Name = "checkVisco";
            this.checkVisco.Size = new System.Drawing.Size(53, 23);
            this.checkVisco.TabIndex = 64;
            this.checkVisco.Text = "Viscous";
            this.checkVisco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkVisco.UseVisualStyleBackColor = true;
            this.checkVisco.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // StorableButton
            // 
            this.StorableButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.StorableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StorableButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StorableButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StorableButton.Image = global::WindowsViewer.Properties.Resources.Storable;
            this.StorableButton.Location = new System.Drawing.Point(3, 185);
            this.StorableButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.StorableButton.Name = "StorableButton";
            this.StorableButton.Size = new System.Drawing.Size(53, 23);
            this.StorableButton.TabIndex = 78;
            this.StorableButton.Text = "Storable";
            this.StorableButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StorableButton.UseVisualStyleBackColor = true;
            this.StorableButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // AirButton
            // 
            this.AirButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AirButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AirButton.Image = global::WindowsViewer.Properties.Resources.Air;
            this.AirButton.Location = new System.Drawing.Point(59, 159);
            this.AirButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.AirButton.Name = "AirButton";
            this.AirButton.Size = new System.Drawing.Size(53, 23);
            this.AirButton.TabIndex = 84;
            this.AirButton.Text = "Aearated";
            this.AirButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirButton.UseVisualStyleBackColor = true;
            this.AirButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkWall
            // 
            this.checkWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkWall.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkWall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkWall.Image = global::WindowsViewer.Properties.Resources.checkWall;
            this.checkWall.Location = new System.Drawing.Point(59, 3);
            this.checkWall.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkWall.Name = "checkWall";
            this.checkWall.Size = new System.Drawing.Size(53, 23);
            this.checkWall.TabIndex = 55;
            this.checkWall.Text = "Wall";
            this.checkWall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkWall.UseVisualStyleBackColor = true;
            this.checkWall.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // JetButton
            // 
            this.JetButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.JetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JetButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.JetButton.Image = global::WindowsViewer.Properties.Resources.Jet;
            this.JetButton.Location = new System.Drawing.Point(115, 133);
            this.JetButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.JetButton.Name = "JetButton";
            this.JetButton.Size = new System.Drawing.Size(53, 23);
            this.JetButton.TabIndex = 83;
            this.JetButton.Text = "Jet";
            this.JetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JetButton.UseVisualStyleBackColor = true;
            this.JetButton.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkWater
            // 
            this.checkWater.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkWater.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkWater.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkWater.Image = global::WindowsViewer.Properties.Resources.checkWater;
            this.checkWater.Location = new System.Drawing.Point(115, 3);
            this.checkWater.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkWater.Name = "checkWater";
            this.checkWater.Size = new System.Drawing.Size(53, 23);
            this.checkWater.TabIndex = 54;
            this.checkWater.Text = "Water";
            this.checkWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkWater.UseVisualStyleBackColor = true;
            this.checkWater.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkSolid
            // 
            this.checkSolid.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkSolid.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSolid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkSolid.Image = global::WindowsViewer.Properties.Resources.checkSolid;
            this.checkSolid.Location = new System.Drawing.Point(171, 3);
            this.checkSolid.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkSolid.Name = "checkSolid";
            this.checkSolid.Size = new System.Drawing.Size(53, 23);
            this.checkSolid.TabIndex = 56;
            this.checkSolid.Text = "Rigid";
            this.checkSolid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSolid.UseVisualStyleBackColor = true;
            this.checkSolid.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkString
            // 
            this.checkString.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkString.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkString.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkString.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkString.Image = global::WindowsViewer.Properties.Resources.checkString;
            this.checkString.Location = new System.Drawing.Point(3, 29);
            this.checkString.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkString.Name = "checkString";
            this.checkString.Size = new System.Drawing.Size(53, 23);
            this.checkString.TabIndex = 58;
            this.checkString.Text = "String";
            this.checkString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkString.UseVisualStyleBackColor = true;
            this.checkString.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox12.Image = global::WindowsViewer.Properties.Resources.YukiMaterial;
            this.checkBox12.Location = new System.Drawing.Point(3, 159);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(53, 23);
            this.checkBox12.TabIndex = 60;
            this.checkBox12.Text = "Yuki";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkLink
            // 
            this.checkLink.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkLink.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkLink.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkLink.Image = global::WindowsViewer.Properties.Resources.checkLink;
            this.checkLink.Location = new System.Drawing.Point(59, 107);
            this.checkLink.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkLink.Name = "checkLink";
            this.checkLink.Size = new System.Drawing.Size(53, 23);
            this.checkLink.TabIndex = 72;
            this.checkLink.Text = "Link";
            this.checkLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkLink.UseVisualStyleBackColor = true;
            this.checkLink.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkElastic
            // 
            this.checkElastic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkElastic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkElastic.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkElastic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkElastic.Image = global::WindowsViewer.Properties.Resources.checkElastic;
            this.checkElastic.Location = new System.Drawing.Point(59, 29);
            this.checkElastic.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkElastic.Name = "checkElastic";
            this.checkElastic.Size = new System.Drawing.Size(53, 23);
            this.checkElastic.TabIndex = 57;
            this.checkElastic.Text = "Elastic";
            this.checkElastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkElastic.UseVisualStyleBackColor = true;
            this.checkElastic.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkBrittle
            // 
            this.checkBrittle.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBrittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBrittle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBrittle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBrittle.Image = global::WindowsViewer.Properties.Resources.checkBrittle;
            this.checkBrittle.Location = new System.Drawing.Point(115, 29);
            this.checkBrittle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkBrittle.Name = "checkBrittle";
            this.checkBrittle.Size = new System.Drawing.Size(53, 23);
            this.checkBrittle.TabIndex = 76;
            this.checkBrittle.Text = "Brittle";
            this.checkBrittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBrittle.UseVisualStyleBackColor = true;
            this.checkBrittle.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkUsers
            // 
            this.checkUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkUsers.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkUsers.Image = global::WindowsViewer.Properties.Resources.checkUsers;
            this.checkUsers.Location = new System.Drawing.Point(171, 133);
            this.checkUsers.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkUsers.Name = "checkUsers";
            this.checkUsers.Size = new System.Drawing.Size(53, 23);
            this.checkUsers.TabIndex = 75;
            this.checkUsers.Text = "User\'s";
            this.checkUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkUsers.UseVisualStyleBackColor = true;
            this.checkUsers.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkAxis
            // 
            this.checkAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkAxis.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAxis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkAxis.Image = global::WindowsViewer.Properties.Resources.radioAxis1;
            this.checkAxis.Location = new System.Drawing.Point(171, 29);
            this.checkAxis.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkAxis.Name = "checkAxis";
            this.checkAxis.Size = new System.Drawing.Size(53, 23);
            this.checkAxis.TabIndex = 71;
            this.checkAxis.Text = "Fulcrum";
            this.checkAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAxis.UseVisualStyleBackColor = true;
            this.checkAxis.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkMochi
            // 
            this.checkMochi.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkMochi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkMochi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMochi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkMochi.Image = global::WindowsViewer.Properties.Resources.checkMochi;
            this.checkMochi.Location = new System.Drawing.Point(3, 55);
            this.checkMochi.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkMochi.Name = "checkMochi";
            this.checkMochi.Size = new System.Drawing.Size(53, 23);
            this.checkMochi.TabIndex = 59;
            this.checkMochi.Text = "Mochi";
            this.checkMochi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMochi.UseVisualStyleBackColor = true;
            this.checkMochi.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkFuel
            // 
            this.checkFuel.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkFuel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkFuel.Image = global::WindowsViewer.Properties.Resources.checkFuel;
            this.checkFuel.Location = new System.Drawing.Point(3, 107);
            this.checkFuel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkFuel.Name = "checkFuel";
            this.checkFuel.Size = new System.Drawing.Size(53, 23);
            this.checkFuel.TabIndex = 62;
            this.checkFuel.Text = "Fuel";
            this.checkFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFuel.UseVisualStyleBackColor = true;
            this.checkFuel.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkHot
            // 
            this.checkHot.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkHot.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkHot.Image = global::WindowsViewer.Properties.Resources.checkHot;
            this.checkHot.Location = new System.Drawing.Point(115, 107);
            this.checkHot.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkHot.Name = "checkHot";
            this.checkHot.Size = new System.Drawing.Size(53, 23);
            this.checkHot.TabIndex = 67;
            this.checkHot.Text = "Hot";
            this.checkHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHot.UseVisualStyleBackColor = true;
            this.checkHot.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkOut
            // 
            this.checkOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkOut.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkOut.Image = global::WindowsViewer.Properties.Resources.checkOut;
            this.checkOut.Location = new System.Drawing.Point(59, 133);
            this.checkOut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(53, 23);
            this.checkOut.TabIndex = 70;
            this.checkOut.Text = "Outflow";
            this.checkOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkOut.UseVisualStyleBackColor = true;
            this.checkOut.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkFlow
            // 
            this.checkFlow.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkFlow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFlow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkFlow.Image = global::WindowsViewer.Properties.Resources.radioFlow;
            this.checkFlow.Location = new System.Drawing.Point(3, 133);
            this.checkFlow.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkFlow.Name = "checkFlow";
            this.checkFlow.Size = new System.Drawing.Size(53, 23);
            this.checkFlow.TabIndex = 69;
            this.checkFlow.Text = "Inflow";
            this.checkFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkFlow.UseVisualStyleBackColor = true;
            this.checkFlow.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkCold
            // 
            this.checkCold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkCold.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCold.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkCold.Image = global::WindowsViewer.Properties.Resources.checkCold;
            this.checkCold.Location = new System.Drawing.Point(171, 107);
            this.checkCold.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkCold.Name = "checkCold";
            this.checkCold.Size = new System.Drawing.Size(53, 23);
            this.checkCold.TabIndex = 68;
            this.checkCold.Text = "Cold";
            this.checkCold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCold.UseVisualStyleBackColor = true;
            this.checkCold.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkRice
            // 
            this.checkRice.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkRice.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkRice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkRice.Image = global::WindowsViewer.Properties.Resources.radioRice;
            this.checkRice.Location = new System.Drawing.Point(59, 55);
            this.checkRice.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkRice.Name = "checkRice";
            this.checkRice.Size = new System.Drawing.Size(53, 23);
            this.checkRice.TabIndex = 65;
            this.checkRice.Text = "Rice";
            this.checkRice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkRice.UseVisualStyleBackColor = true;
            this.checkRice.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkTensil
            // 
            this.checkTensil.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTensil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkTensil.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTensil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkTensil.Image = global::WindowsViewer.Properties.Resources.checkTensil;
            this.checkTensil.Location = new System.Drawing.Point(59, 81);
            this.checkTensil.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkTensil.Name = "checkTensil";
            this.checkTensil.Size = new System.Drawing.Size(53, 23);
            this.checkTensil.TabIndex = 63;
            this.checkTensil.Text = "Tensile";
            this.checkTensil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTensil.UseVisualStyleBackColor = true;
            this.checkTensil.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkLight
            // 
            this.checkLight.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkLight.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkLight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkLight.Image = global::WindowsViewer.Properties.Resources.checkLight;
            this.checkLight.Location = new System.Drawing.Point(171, 81);
            this.checkLight.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkLight.Name = "checkLight";
            this.checkLight.Size = new System.Drawing.Size(53, 23);
            this.checkLight.TabIndex = 73;
            this.checkLight.Text = "Light";
            this.checkLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkLight.UseVisualStyleBackColor = true;
            this.checkLight.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkHeavy
            // 
            this.checkHeavy.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHeavy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkHeavy.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHeavy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkHeavy.Image = global::WindowsViewer.Properties.Resources.checkHeavy;
            this.checkHeavy.Location = new System.Drawing.Point(115, 81);
            this.checkHeavy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkHeavy.Name = "checkHeavy";
            this.checkHeavy.Size = new System.Drawing.Size(53, 23);
            this.checkHeavy.TabIndex = 74;
            this.checkHeavy.Text = "Dense";
            this.checkHeavy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHeavy.UseVisualStyleBackColor = true;
            this.checkHeavy.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkPowder
            // 
            this.checkPowder.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkPowder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkPowder.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPowder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkPowder.Image = global::WindowsViewer.Properties.Resources.checkPowder;
            this.checkPowder.Location = new System.Drawing.Point(115, 55);
            this.checkPowder.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkPowder.Name = "checkPowder";
            this.checkPowder.Size = new System.Drawing.Size(53, 23);
            this.checkPowder.TabIndex = 61;
            this.checkPowder.Text = "Powder";
            this.checkPowder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPowder.UseVisualStyleBackColor = true;
            this.checkPowder.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // checkGas
            // 
            this.checkGas.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkGas.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkGas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkGas.Image = global::WindowsViewer.Properties.Resources.checkGas;
            this.checkGas.Location = new System.Drawing.Point(171, 55);
            this.checkGas.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.checkGas.Name = "checkGas";
            this.checkGas.Size = new System.Drawing.Size(53, 23);
            this.checkGas.TabIndex = 66;
            this.checkGas.Text = "Gas";
            this.checkGas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkGas.UseVisualStyleBackColor = true;
            this.checkGas.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.groupBoxGraphical);
            this.panel2.Controls.Add(this.groupBoxBasic);
            this.panel2.Controls.Add(this.groupBoxTool);
            this.panel2.Controls.Add(this.groupBoxScene);
            this.panel2.Location = new System.Drawing.Point(800, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 700);
            this.panel2.TabIndex = 53;
            // 
            // groupBoxGraphical
            // 
            this.groupBoxGraphical.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadWatermark);
            this.groupBoxGraphical.Controls.Add(this.buttonWatermark);
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadBubble);
            this.groupBoxGraphical.Controls.Add(this.buttonBubbleTexture);
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadSplash);
            this.groupBoxGraphical.Controls.Add(this.buttonSplashTexture);
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadFire);
            this.groupBoxGraphical.Controls.Add(this.buttonFireTexture);
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadBack);
            this.groupBoxGraphical.Controls.Add(this.buttonBackground);
            this.groupBoxGraphical.Controls.Add(this.buttonUnloadFore);
            this.groupBoxGraphical.Controls.Add(this.buttonForeground);
            this.groupBoxGraphical.Controls.Add(this.comboBoxStyle);
            this.groupBoxGraphical.Controls.Add(this.label1);
            this.groupBoxGraphical.Location = new System.Drawing.Point(5, 505);
            this.groupBoxGraphical.Name = "groupBoxGraphical";
            this.groupBoxGraphical.Size = new System.Drawing.Size(239, 199);
            this.groupBoxGraphical.TabIndex = 54;
            this.groupBoxGraphical.TabStop = false;
            this.groupBoxGraphical.Text = "Graphics";
            // 
            // buttonUnloadWatermark
            // 
            this.buttonUnloadWatermark.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadWatermark.Location = new System.Drawing.Point(170, 170);
            this.buttonUnloadWatermark.Name = "buttonUnloadWatermark";
            this.buttonUnloadWatermark.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadWatermark.TabIndex = 50;
            this.buttonUnloadWatermark.Text = "Unload";
            this.buttonUnloadWatermark.UseVisualStyleBackColor = true;
            this.buttonUnloadWatermark.Click += new System.EventHandler(this.buttonUnloadWatermark_Click);
            // 
            // buttonWatermark
            // 
            this.buttonWatermark.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonWatermark.Location = new System.Drawing.Point(12, 170);
            this.buttonWatermark.Name = "buttonWatermark";
            this.buttonWatermark.Size = new System.Drawing.Size(152, 23);
            this.buttonWatermark.TabIndex = 49;
            this.buttonWatermark.Text = "Load Watermark Texture";
            this.buttonWatermark.UseVisualStyleBackColor = true;
            this.buttonWatermark.Click += new System.EventHandler(this.buttonWatermark_Click);
            // 
            // buttonUnloadBubble
            // 
            this.buttonUnloadBubble.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadBubble.Location = new System.Drawing.Point(170, 144);
            this.buttonUnloadBubble.Name = "buttonUnloadBubble";
            this.buttonUnloadBubble.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadBubble.TabIndex = 48;
            this.buttonUnloadBubble.Text = "Unload";
            this.buttonUnloadBubble.UseVisualStyleBackColor = true;
            this.buttonUnloadBubble.Click += new System.EventHandler(this.buttonUnloadBubble_Click);
            // 
            // buttonBubbleTexture
            // 
            this.buttonBubbleTexture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBubbleTexture.Location = new System.Drawing.Point(12, 144);
            this.buttonBubbleTexture.Name = "buttonBubbleTexture";
            this.buttonBubbleTexture.Size = new System.Drawing.Size(152, 23);
            this.buttonBubbleTexture.TabIndex = 47;
            this.buttonBubbleTexture.Text = "Load Bubble Texture";
            this.buttonBubbleTexture.UseVisualStyleBackColor = true;
            this.buttonBubbleTexture.Click += new System.EventHandler(this.buttonBubbleTexture_Click);
            // 
            // buttonUnloadSplash
            // 
            this.buttonUnloadSplash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadSplash.Location = new System.Drawing.Point(170, 118);
            this.buttonUnloadSplash.Name = "buttonUnloadSplash";
            this.buttonUnloadSplash.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadSplash.TabIndex = 46;
            this.buttonUnloadSplash.Text = "Unload";
            this.buttonUnloadSplash.UseVisualStyleBackColor = true;
            this.buttonUnloadSplash.Click += new System.EventHandler(this.buttonUnloadSplash_Click);
            // 
            // buttonSplashTexture
            // 
            this.buttonSplashTexture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSplashTexture.Location = new System.Drawing.Point(12, 118);
            this.buttonSplashTexture.Name = "buttonSplashTexture";
            this.buttonSplashTexture.Size = new System.Drawing.Size(152, 23);
            this.buttonSplashTexture.TabIndex = 45;
            this.buttonSplashTexture.Text = "Load Splash Texture";
            this.buttonSplashTexture.UseVisualStyleBackColor = true;
            this.buttonSplashTexture.Click += new System.EventHandler(this.buttonSplashTexture_Click);
            // 
            // buttonUnloadFire
            // 
            this.buttonUnloadFire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadFire.Location = new System.Drawing.Point(170, 92);
            this.buttonUnloadFire.Name = "buttonUnloadFire";
            this.buttonUnloadFire.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadFire.TabIndex = 44;
            this.buttonUnloadFire.Text = "Unload";
            this.buttonUnloadFire.UseVisualStyleBackColor = true;
            this.buttonUnloadFire.Click += new System.EventHandler(this.buttonUnloadFire_Click);
            // 
            // buttonFireTexture
            // 
            this.buttonFireTexture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFireTexture.Location = new System.Drawing.Point(12, 92);
            this.buttonFireTexture.Name = "buttonFireTexture";
            this.buttonFireTexture.Size = new System.Drawing.Size(152, 23);
            this.buttonFireTexture.TabIndex = 43;
            this.buttonFireTexture.Text = "Load Fire Texture";
            this.buttonFireTexture.UseVisualStyleBackColor = true;
            this.buttonFireTexture.Click += new System.EventHandler(this.buttonFireTexture_Click);
            // 
            // buttonUnloadBack
            // 
            this.buttonUnloadBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadBack.Location = new System.Drawing.Point(170, 66);
            this.buttonUnloadBack.Name = "buttonUnloadBack";
            this.buttonUnloadBack.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadBack.TabIndex = 42;
            this.buttonUnloadBack.Text = "Unload";
            this.buttonUnloadBack.UseVisualStyleBackColor = true;
            this.buttonUnloadBack.Click += new System.EventHandler(this.buttonUnloadBack_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBackground.Location = new System.Drawing.Point(12, 66);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(152, 23);
            this.buttonBackground.TabIndex = 41;
            this.buttonBackground.Text = "Load Background";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonUnloadFore
            // 
            this.buttonUnloadFore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUnloadFore.Location = new System.Drawing.Point(170, 40);
            this.buttonUnloadFore.Name = "buttonUnloadFore";
            this.buttonUnloadFore.Size = new System.Drawing.Size(55, 23);
            this.buttonUnloadFore.TabIndex = 40;
            this.buttonUnloadFore.Text = "Unload";
            this.buttonUnloadFore.UseVisualStyleBackColor = true;
            this.buttonUnloadFore.Click += new System.EventHandler(this.buttonUnloadFore_Click);
            // 
            // buttonForeground
            // 
            this.buttonForeground.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonForeground.Location = new System.Drawing.Point(12, 40);
            this.buttonForeground.Name = "buttonForeground";
            this.buttonForeground.Size = new System.Drawing.Size(152, 23);
            this.buttonForeground.TabIndex = 39;
            this.buttonForeground.Text = "Load Foreground";
            this.buttonForeground.UseVisualStyleBackColor = true;
            this.buttonForeground.Click += new System.EventHandler(this.buttonForeground_Click);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Points",
            "Crosses",
            "Circles",
            "Blurred",
            "Contour",
            "Texture"});
            this.comboBoxStyle.Location = new System.Drawing.Point(46, 16);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(157, 21);
            this.comboBoxStyle.TabIndex = 1;
            this.comboBoxStyle.TextChanged += new System.EventHandler(this.comboBoxStyle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Style:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1061, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Panel_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxScene.ResumeLayout(false);
            this.groupBoxScene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPouring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGravity)).EndInit();
            this.groupBoxBasic.ResumeLayout(false);
            this.tabControlMaterials.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageCustom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxGraphical.ResumeLayout(false);
            this.groupBoxGraphical.PerformLayout();
            this.ResumeLayout(false);

        }
#pragma warning disable CS0649
        private global::System.ComponentModel.IContainer components;
#pragma warning restore CS0649
        private global::System.Windows.Forms.MenuStrip menuMain;
        private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private global::System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem engineToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem aboutPhyziosStudioProToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem quitPhyziosStudioProToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem revertToSavedToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem movieCapturingToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem playSoundToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem brigAllToFrontToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem pHYZIOSStudioProHelpToolStripMenuItem;
        private global::System.Windows.Forms.SaveFileDialog saveMovieFile;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.ToolStripMenuItem saveToLocalAndWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioZombie;
        private System.Windows.Forms.RadioButton radioBrittle;
        private System.Windows.Forms.RadioButton radioUsers;
        private System.Windows.Forms.RadioButton radioJet;
        private System.Windows.Forms.RadioButton radioOil;
        private System.Windows.Forms.RadioButton radioBlank0;
        private System.Windows.Forms.RadioButton radioAxis;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioFlow;
        private System.Windows.Forms.RadioButton radioCold;
        private System.Windows.Forms.RadioButton radioHot;
        private System.Windows.Forms.RadioButton radioGas;
        private System.Windows.Forms.RadioButton radioRice;
        private System.Windows.Forms.RadioButton radioVisco;
        private System.Windows.Forms.RadioButton radioMochi;
        private System.Windows.Forms.RadioButton radioTensil;
        private System.Windows.Forms.RadioButton radioPowder;
        private System.Windows.Forms.RadioButton radioFire;
        private System.Windows.Forms.RadioButton radioFuel;
        private System.Windows.Forms.RadioButton radioString;
        private System.Windows.Forms.RadioButton radioErastic;
        private System.Windows.Forms.RadioButton radioRigid;
        private System.Windows.Forms.RadioButton radioWall;
        private System.Windows.Forms.RadioButton radioAqua;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.RadioButton radioDense;
        private System.Windows.Forms.RadioButton radioLight;
        private System.Windows.Forms.GroupBox groupBoxScene;
        private System.Windows.Forms.CheckBox checkBoxPause;
        private System.Windows.Forms.CheckBox checkBoxDrain;
        private System.Windows.Forms.CheckBox checkBoxSplash;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxGravity;
        private System.Windows.Forms.TrackBar trackBarGravity;
        private System.Windows.Forms.CheckBox checkBoxPouring;
        private System.Windows.Forms.TrackBar trackBarPouring;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.RadioButton radioBrush;
        private System.Windows.Forms.RadioButton radioPencil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioShape;
        private System.Windows.Forms.RadioButton radioBucket;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.RadioButton radioEraser;
        private System.Windows.Forms.RadioButton radioReplace;
        private System.Windows.Forms.RadioButton radioSpuit;
        private System.Windows.Forms.RadioButton radioArrow;
        private System.Windows.Forms.RadioButton radioSlice;
        private System.Windows.Forms.RadioButton radioSelect;
        private System.Windows.Forms.RadioButton radioMarker;
        private System.Windows.Forms.RadioButton radioChgColor;
        private System.Windows.Forms.RadioButton radioLink;
        private System.Windows.Forms.RadioButton radioToolAxis;
        private System.Windows.Forms.RadioButton radioControl;
        private System.Windows.Forms.GroupBox groupBoxGraphical;
        private System.Windows.Forms.TabControl tabControlMaterials;
        private System.Windows.Forms.TabPage tabPageBasic;
        private System.Windows.Forms.TabPage tabPageCustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Button buttonForeground;
        private System.Windows.Forms.Button buttonUnloadBubble;
        private System.Windows.Forms.Button buttonBubbleTexture;
        private System.Windows.Forms.Button buttonUnloadSplash;
        private System.Windows.Forms.Button buttonSplashTexture;
        private System.Windows.Forms.Button buttonUnloadFire;
        private System.Windows.Forms.Button buttonFireTexture;
        private System.Windows.Forms.Button buttonUnloadBack;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonUnloadFore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonWatermark;
        private System.Windows.Forms.Button buttonUnloadWatermark;
        private System.Windows.Forms.CheckBox NoneButton;
        private System.Windows.Forms.CheckBox checkVisco;
        private System.Windows.Forms.CheckBox ReservedButton;
        private System.Windows.Forms.CheckBox AirButton;
        private System.Windows.Forms.CheckBox JetButton;
        private System.Windows.Forms.CheckBox checkSolid;
        private System.Windows.Forms.CheckBox NaturalButton;
        private System.Windows.Forms.CheckBox checkElastic;
        private System.Windows.Forms.CheckBox JoinableButton;
        private System.Windows.Forms.CheckBox checkString;
        private System.Windows.Forms.CheckBox SelectedButton;
        private System.Windows.Forms.CheckBox checkMochi;
        private System.Windows.Forms.CheckBox TexturedButton;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox StorableButton;
        private System.Windows.Forms.CheckBox checkPowder;
        private System.Windows.Forms.CheckBox checkFuel;
        private System.Windows.Forms.CheckBox checkBrittle;
        private System.Windows.Forms.CheckBox checkTensil;
        private System.Windows.Forms.CheckBox checkUsers;
        private System.Windows.Forms.CheckBox checkRice;
        private System.Windows.Forms.CheckBox checkHeavy;
        private System.Windows.Forms.CheckBox checkGas;
        private System.Windows.Forms.CheckBox checkLight;
        private System.Windows.Forms.CheckBox checkHot;
        private System.Windows.Forms.CheckBox checkLink;
        private System.Windows.Forms.CheckBox checkCold;
        private System.Windows.Forms.CheckBox checkAxis;
        private System.Windows.Forms.CheckBox checkFlow;
        private System.Windows.Forms.CheckBox checkOut;
        private System.Windows.Forms.CheckBox checkZombie;
        private System.Windows.Forms.CheckBox checkWall;
        private System.Windows.Forms.CheckBox checkWater;
        private System.Windows.Forms.ToolStripMenuItem gCCollectToolStripMenuItem;
        private TrackBar trackBarAlpha;
        private TextBox textBoxAlpha;
        private ToolStripMenuItem hideSidePanelToolStripMenuItem;
    }
}
