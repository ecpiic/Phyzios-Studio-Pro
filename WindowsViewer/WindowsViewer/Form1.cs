using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Microsoft.Win32;
using oec;
using OECasualCSharp;
namespace WindowsViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.SceneTitle = "Untitled";
            this.SceneDescription = "";
            this.PublishFlag = false;
            this.EnableTag = true;
            this.ToolLimit = true;
        }
        public PanelController GetPanelController()
        {
            return this.panelController;
        }
        public OECPanel GetOECPanel()
        {
            return this.panelController.panelOECMain;
        }
        public void SetTool(Tools tool)
        {
            this.panelController.Scene.LeftButtonTool = tool;
        }
        public void SetMaterial(Materials mate)
        {
            this.panelController.NextMaterial = mate;
        }
        public void SetParticleInfo(ParticleInfoManaged info)
        {
            this.panelController.NextParticleInfo = info;
        }
        public void SetColor(global::System.Drawing.Color col)
        {
            this.panelController.NextColor = Form1.ToMColor(col);
        }
        public void NewScene()
        {
            this.SetSceneTitle("Untitled");
            this.SceneDescription = "";
            this.SceneTags = "";
            this.SceneID = string.Empty;
            this.SceneUserID = string.Empty;
            this.SceneParentID = string.Empty;
            this.SceneAPGID = string.Empty;
            this.PublishFlag = false;
            this.UseScript = false;
            this.EnableTag = true;
            this.LastLoadData = null;
            this.panelController.Scene.ClearAll();
            this.panelController.Config.SoundFlag = false;
            this.FormResize(0, 0, true);
            this.UpdatePropertyWindow();
            this.panelController.OldUndoCount = this.panelController.Scene.GetUndoCount();
            this.panelController.IsModified = false;
            this.panelController.SetPath("SysTmpGameData.oecd/");
        }
        public void SetUseScript()
        {
            this.UseScript = true;
        }
        public void SetSceneTitle(string title)
        {
            this.SceneTitle = title;
            this.Text = title;
        }
        private global::System.Drawing.Color FromMColor(global::System.Windows.Media.Color col)
        {
            return global::System.Drawing.Color.FromArgb((int)trackBarAlpha.Value, (int)col.R, (int)col.G, (int)col.B);
        }
        public static global::System.Windows.Media.Color ToMColor(global::System.Drawing.Color col)
        {
            return global::System.Windows.Media.Color.FromArgb(col.A, col.R, col.G, col.B);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int menuHeight = (this.MainMenuStrip != null) ? this.MainMenuStrip.Height : 0;

            this.MaterialNameList = new MaterialNames();
            this.MaterialNameList.Add(Materials.Aqua, "Water");
            this.MaterialNameList.Add(Materials.Wall, "Wall");
            this.MaterialNameList.Add(Materials.Rigid, "Solid");
            this.MaterialNameList.Add(Materials.Elastic, "Elastic");
            this.MaterialNameList.Add(Materials.String, "String");
            this.MaterialNameList.Add(Materials.Mochi, "Rice Cake");
            this.MaterialNameList.Add(Materials.Fire, "Fire");
            this.MaterialNameList.Add(Materials.Powder, "Powder");
            this.MaterialNameList.Add(Materials.Fuel, "Wood");
            this.MaterialNameList.Add(Materials.Tensile, "Surface Tension");
            this.MaterialNameList.Add(Materials.Viscous, "Viscous");
            this.MaterialNameList.Add(Materials.Kome, "Rice");
            this.MaterialNameList.Add(Materials.Gas, "Steam");
            this.MaterialNameList.Add(Materials.Hot, "Hot Wall");
            this.MaterialNameList.Add(Materials.Cold, "Cold Wall");
            this.MaterialNameList.Add(Materials.Inflow, "Faucet");
            this.MaterialNameList.Add(Materials.Outflow, "Outflow");
            this.MaterialNameList.Add(Materials.Axis, "Fulcrum");
            this.MaterialNameList.Add(Materials.Light, "Oil");
            this.MaterialNameList.Add(Materials.Users, "Character");
            this.MaterialNameList.Add(Materials.Brittle, "Brittle");
            this.MaterialNameList.Add(Materials.Yuki, "Yuki");
            this.MaterialNameList.Add(Materials.Dense, "Dense");
            this.MaterialNameList.Add(Materials.Light, "Light");
            this.panelController = new PanelController(this);
            this.FormResize(0, 0, true);
            this.panelController.SetTimerEnable(true);
            this.panelController.SetMouseEnable(true);
            this.panelController.IsSimulating = true;
            this.panelController.Config.ScrollFlag = false;
            this.panelController.Config.SoundFlag = false;
            this.panelController.panelOECMain.KeyUp += this.Panel_KeyUp;
            this.panelController.Scene.LevelsOfUndo = 20;
            this.panelController.OnAfterMouseUp += this.panelOEC_OnAfterMouseUp;
            this.panelController.panelOECMain.Margin = new Padding(0);
            this.panel1.Controls.Add(this.panelController.panelOECMain);
            this.panelController.NextMaterial = Materials.Wall;
            this.panelController.Scene.LeftButtonTool = Tools.PencilTool;
            this.NewScene();
            base.SetDesktopLocation(350, 80);
            this.panelController.Config.PauseFlag = false;
            this.Size = new Size(1077, 763);
            this.panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - menuHeight);
            this.panel1.Location = new Point(0, menuHeight);
            this.GetPanelController().Config.BoundsWidth = this.panel1.Width / this.GetPanelController().Config.Scale;
            this.GetPanelController().Config.BoundsHeight = this.panel1.Height / this.GetPanelController().Config.Scale;
            this.panelController.Config.GravityAcceleration = (float)this.trackBarGravity.Value / 2000000f;
            this.panelController.Config.PouringVelocity = (float)this.trackBarPouring.Value / 5000f;
            this.panelController.Config.TimeStepsPerFrame = 8;
            this.panelController.StartSim();
            this.UpdateUI();
            this.FormResize(0, 0, false);
        }
        private void SetToolAndMaterial()
        {
            Materials materials = (Materials)ParticleDataManaged.MaterialForInfo(this.panelController.NextParticleInfo);
            this.SetButtons(materials, this.panelController.NextParticleInfo);           
        }
        private void panelOEC_OnAfterMouseUp()
        {
            if (this.panelController.LeftButtonTool == Tools.SamplerTool)
            {
                this.SetToolAndMaterial();
            }
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
                if (this.panelController.LeftButtonTool == Tools.MarqueeTool)
                {
                    this.BrowserWindow.SelectNodeWithBodyID(this.GetMinSelectedBodyID());
                }
            }
        }
        public int GetMinSelectedBodyID()
        {
            ParticleDataManaged data = this.panelController.Scene.Particles.Data;
            for (int i = 0; i < data.Count; i++)
            {
                if ((data.GetInfo(i) & ParticleInfoManaged.Selected) == ParticleInfoManaged.Selected)
                {
                    return data.get_BodyID(i);
                }
            }
            return 0;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                    this.panelController.Config.PauseFlag = !this.panelController.Config.PauseFlag;
                    this.checkBoxPause.Checked = panelController.Config.PauseFlag;
                    return true;

                case Keys.Enter:
                    if (this.textBoxAlpha.Focused)
                    {
                        this.trackBarAlpha.Value = Int16.Parse(this.textBoxAlpha.Text);
                        return true;
                    }

                    this.panelController.OneFrame = true;

                    if (this.panelController.Config.PauseFlag == true)
                    {
                        this.panelController.Config.PauseFlag = false;
                        return true;
                    }

                    this.checkBoxPause.Checked = true;
                    return true;

                case Keys.F:
                    this.panelController.Scene.FreezeAll();
                    return true;

                case Keys.OemPeriod:
                    this.GetPanelController().Config.PouringFlag = !this.GetPanelController().Config.PouringFlag;
                    this.checkBoxPouring.Checked = panelController.Config.PouringFlag;
                    return true;

                case Keys.D1:
                    this.GetPanelController().Config.RenderMode = 1;
                    this.comboBoxStyle.SelectedIndex = 0;
                    return true;

                case Keys.D2:
                    this.GetPanelController().Config.RenderMode = 2;
                    this.comboBoxStyle.SelectedIndex = 1;
                    return true;

                case Keys.D3:
                    this.GetPanelController().Config.RenderMode = 3;
                    this.comboBoxStyle.SelectedIndex = 2;
                    return true;

                case Keys.D4:
                    this.GetPanelController().Config.RenderMode = 4;
                    this.comboBoxStyle.SelectedIndex = 3;
                    return true;

                case Keys.D5:
                    this.GetPanelController().Config.RenderMode = 5;
                    this.comboBoxStyle.SelectedIndex = 4;
                    return true;

                case Keys.D6:
                    this.GetPanelController().Config.RenderMode = 6;
                    this.comboBoxStyle.SelectedIndex = 5;
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Panel_KeyUp(object sender, KeyEventArgs e)
        {
            this.panelController.KeyUpEvent(e);
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string[] array2 = array;
                foreach (string text in array2)
                {
                    this.panelController.LoadLocalData(text);
                    this.panelController.panelOECMain.Focus();
                }
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
                return;
            }
            e.Effect = DragDropEffects.None;
        }
        private void UpdatePropertyWindow()
        {
            if (this.PropertyWindow != null && !this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow.UpdateParam();
            }
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TimeWindow == null || this.TimeWindow.IsDisposed)
            {
                this.TimeWindow = new TimeForm(this);
                this.TimeWindow.UpdateParam();
                this.TimeWindow.Show();
                this.TimeWindow.Activate();
                return;
            }
            this.TimeWindow.Close();
            this.TimeWindow = null;
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PropertyWindow == null || this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow = new PropertyForm(this, this.panelController);
                this.PropertyWindow.UpdateParam();
                this.PropertyWindow.Show();
                this.PropertyWindow.Activate();
                return;
            }
            this.PropertyWindow.Close();
            this.PropertyWindow = null;
        }
        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BrowserWindow == null || this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow = new BrowserForm(this);
                this.BrowserWindow.UpdateParam();
                this.BrowserWindow.Show();
                this.BrowserWindow.Activate();
                return;
            }
            this.BrowserWindow.Close();
            this.BrowserWindow = null;
        }
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.StatusWindow == null || this.StatusWindow.IsDisposed)
            {
                this.StatusWindow = new StatusForm(this);
                this.StatusWindow.UpdateParam();
                this.StatusWindow.Show();
                this.StatusWindow.Activate();
                return;
            }
            this.StatusWindow.Close();
            this.StatusWindow = null;
        }
        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ParametersWindow == null || this.ParametersWindow.IsDisposed)
            {
                this.ParametersWindow = new ParametersForm(this.panelController.Config);
                this.ParametersWindow.Show();
                this.ParametersWindow.Activate();
                return;
            }
            this.ParametersWindow.Close();
            this.ParametersWindow = null;
        }
        private void brigAllToFrontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TimeWindow != null && !this.TimeWindow.IsDisposed)
            {
                this.TimeWindow.Activate();
            }
            if (this.PropertyWindow != null && !this.PropertyWindow.IsDisposed)
            {
                this.PropertyWindow.Activate();
            }
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.Activate();
            }
            if (this.StatusWindow != null && !this.StatusWindow.IsDisposed)
            {
                this.StatusWindow.Activate();
            }
            if (this.ParametersWindow != null && !this.ParametersWindow.IsDisposed)
            {
                this.ParametersWindow.Activate();
            }
        }
        private void editToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (this.panelController.Scene.GetUndoCount() > 0)
            {
                this.undoToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.undoToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.GetRedoCount() > 0)
            {
                this.redoToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.redoToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.particleBuilder.CountParticles(ParticleInfoManaged.Selected) > 0)
            {
                this.copyToolStripMenuItem.Enabled = true;
                this.cutToolStripMenuItem.Enabled = true;
                this.deselectAllToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.copyToolStripMenuItem.Enabled = false;
                this.cutToolStripMenuItem.Enabled = false;
                this.deselectAllToolStripMenuItem.Enabled = false;
            }
            if (this.panelController.Scene.IsCopyExist())
            {
                this.pasteToolStripMenuItem.Enabled = true;
                return;
            }
            this.pasteToolStripMenuItem.Enabled = false;
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Undo();
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.Redo();
            if (this.BrowserWindow != null && !this.BrowserWindow.IsDisposed)
            {
                this.BrowserWindow.UpdateParam();
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsCopyable())
            {
                this.panelController.Scene.RegisterUndo();
                this.panelController.Scene.CopySelection();
                this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.Selected);
                return;
            }
            MessageBox.Show("The Art Piece could not be copied.");
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsCopyable())
            {
                this.panelController.Scene.CopySelection();
                return;
            }
            MessageBox.Show("The Art Piece could not be copied.");
        }
        private bool IsCopyable()
        {
            return true;
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.RegisterUndo();
            this.panelController.Scene.Paste();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.Selected);
        }
        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.FixForm();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.SelectAllParticles();
        }
        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.UnselectAllParticles();
        }
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void engineToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (this.panelController.Config.SoundFlag)
            {
                this.playSoundToolStripMenuItem.Checked = true;
            }
            else
            {
                this.playSoundToolStripMenuItem.Checked = false;
            }          
        }
       
        private void movieCapturingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsRecording())
            {
                this.StopRecording();
                return;
            }
            this.Record();
        }
        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
      
        private void playSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.playSoundToolStripMenuItem.Checked)
            {
                this.panelController.Config.SoundFlag = false;
                this.playSoundToolStripMenuItem.Checked = false;
            }
            else
            {
                this.panelController.Config.SoundFlag = true;
                this.playSoundToolStripMenuItem.Checked = true;
            }
            this.UpdatePropertyWindow();
        }

        public void Record()
        {
            this.StopRecording();
            if (this.saveMovieFile.ShowDialog() == DialogResult.OK)
            {
                this.panelController.Record(this.saveMovieFile.FileName);
            }
            if (this.IsRecording())
            {
                this.movieCapturingToolStripMenuItem.Checked = true;
                return;
            }
            this.movieCapturingToolStripMenuItem.Checked = false;
        }
        public void StopRecording()
        {
            if (this.panelController.Scene.IsRecording)
            {
                this.panelController.StopRecording();
            }
            if (this.IsRecording())
            {
                this.movieCapturingToolStripMenuItem.Checked = true;
                return;
            }
            this.movieCapturingToolStripMenuItem.Checked = false;
        }
        public bool IsRecording()
        {
            return this.panelController.Scene.IsRecording;
        }
        private void aboutPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void quitPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void logoutPhyziosStudioProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
            if (base.IsDisposed)
            {
                Registry.CurrentUser.DeleteSubKey("PHYZIOS Studio Pro");
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelController.IsModified)
            {
                BeforeClose beforeClose = new BeforeClose("Do you want to save the changes you made in the document \"" + this.SceneTitle + "\"?", "Your changes will be lost if you don't save them.");
                DialogResult dialogResult = beforeClose.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    this.CheckSave(false);
                }
            }
            this.panelController.enterFromClear = true;
            this.panelController.Clear();
            this.panelController.beat.ClearFileSystem();
            this.panelController.Config.ForegroundTexture = null;
            this.panelController.Config.BackgroundTexture = null;
            this.panelController.Config.WatermarkTexture = null;
            this.panelController.Config.FireTexture = null;
            this.panelController.Config.SplashTexture = null;
            this.panelController.Config.BubbleTexture = null;
            this.NewScene();
            this.panelController.Config.PauseFlag = false;
            this.checkBoxPause.Checked = false;
            this.FixForm();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "OEC Files|*.oec";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.SceneTitle = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                this.panelController.LoadLocalData(openFileDialog.FileName);
                this.panelController.panelOECMain.Focus();
                this.Location = new Point(0, 0);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private string GetPostString(string boundary, string name, string str)
        {
            return string.Concat(new string[] { "--", boundary, "\r\nContent-Disposition: form-data; name=\"", name, "\"\r\n\r\n", str, "\r\n" });
        }
        private string GetOriginalAP_ID(string ap_id)
        {
            if (!string.IsNullOrEmpty(ap_id))
            {
                int num = ap_id.LastIndexOf("-");
                if (num > 0)
                {
                    return ap_id.Substring(0, num);
                }
            }
            return string.Empty;
        }
        private void CheckSave(bool Local)
        {
            this.SaveScene(true);
        }
        private string GetArtPieceList()
        {
            List<string> list = new List<string>(this.panelController.Scene.Scene.FileManager.GetIncludeAPIDs());
            string text = string.Empty;
            foreach (string text2 in list)
            {
                text = ((!string.IsNullOrEmpty(text)) ? (text + "," + text2) : text2);
            }
            return text;
        }
        private void SaveScene(bool Local)
        {
            this.panelController.Scene.UnselectAllParticles();
            FileManagerCSharp fileManagerCSharp = new FileManagerCSharp(this.panelController.Scene.Scene.FileManager);
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "OEC Files|*.oec"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(saveFileDialog.FileName));
                string text = fileManagerCSharp.CreateSaveString();
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.Write(text);
                    }
                }
                this.panelController.IsModified = false;
                MessageBox.Show("Save Complete.", "PHYZIOS Studio Pro");
            }
            this.EnableTag = false;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckSave(false);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void revertToSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelController.LoadData(this.LastLoadData);
        }
        private void fileToolStripMenuItem1_DropDownOpened(object sender, EventArgs e)
        {
            if (this.LastLoadData == null)
            {
                this.revertToSavedToolStripMenuItem.Enabled = false;
                return;
            }
            this.revertToSavedToolStripMenuItem.Enabled = true;
        }

        private void pHYZIOSStudioProHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Documentation/Phyzios_Studio_Pro_Manual_Ver1.0.pdf";
            if (!File.Exists(text))
            {
                text = "Phyzios_Studio_Pro_Manual_Ver1.0.pdf";
            }
            if (File.Exists(text))
            {
                Process.Start("Phyzios_Studio_Pro_Manual_Ver1.0.pdf");
                return;
            }
            MessageBox.Show("Help isn't available for PHYZIOS Studio Pro.");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.FormResize(0, 0, false);
        }

        public void FormResize(int x, int y, bool resizeForm = false, bool hidepanel = false)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            if (!resizeForm)
            {
                this.GetPanelController().Config.BoundsWidth = (float)(int)(this.Width - DylanWasHere) / this.GetPanelController().Config.Scale;
                this.GetPanelController().Config.BoundsHeight = (float)(int)(this.Height - 63) / this.GetPanelController().Config.Scale;
            }

            int width = (int)(this.GetPanelController().Config.BoundsWidth * this.GetPanelController().Config.Scale);
            int height = (int)(this.GetPanelController().Config.BoundsHeight * this.GetPanelController().Config.Scale);

            if (resizeForm)
            {
                this.Width = (width + DylanWasHere);
                this.Height = (height + 63);
            }

            if (hidepanel)
            {
                this.Width = ((width - 261) + DylanWasHere);
            }
 
            this.panel1.Size = new Size(width, height);
            this.panel1.Location = new Point(0, 24);
            this.panel2.Size = new Size(261, height);
            this.panel2.Location = new Point((this.Width - DylanWasHere), 24);


            this.GetPanelController().panelOECMain.Left = x;
            this.GetPanelController().panelOECMain.Top = y;

            this.GetPanelController().panelOECMain.Size = this.panel1.Size;
            this.GetPanelController().panelOECMain.Location = new Point(0, 0);

            this.GetPanelController().originalWidth = this.panel1.Width;
            this.GetPanelController().originalHeight = this.panel1.Height;

            this.GetPanelController().Scene.SceneRenderer.SetViewport(this.panel1.Width, this.panel1.Height);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.panelController != null && this.panelController.IsModified)
            {
                BeforeClose beforeClose = new BeforeClose("Do you want to save the changes you made in the document \"" + this.SceneTitle + "\"?", "Your changes will be lost if you don't save them.");
                DialogResult dialogResult = beforeClose.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                else
                {
                    this.CheckSave(false);
                }
            }
        }
        public void SelectBody(int bodyid)
        {
            this.panelController.Scene.UnselectAllParticles();
            this.panelController.Scene.particleBuilder.SelectBody(bodyid);
        }
        private void saveToLocalAndWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckSave(true);
        }

        private void Basic_CheckedChanged(object sender, EventArgs e)
        {
            this.SetMaterialName();
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCustomMaterial();
        }

        public void SetMaterialName()
        {
            ParticleInfoManaged particleInfoManaged = ParticleInfoManaged.None;
            System.Drawing.Color jetColor = System.Drawing.Color.FromArgb(255, 255, 202, 25);
            System.Drawing.Color lightColor = System.Drawing.Color.FromArgb(255, 152, 230, 230);
            this.GetOECPanel();
            if (this.radioAqua.Checked)
            {
                this.SetMaterial(Materials.Aqua);
            }
            if (this.radioWall.Checked)
            {
                this.SetMaterial(Materials.Wall);
            }
            if (this.radioRigid.Checked)
            {
                this.SetMaterial(Materials.Rigid);
            }
            if (this.radioErastic.Checked)
            {
                this.SetMaterial(Materials.Elastic);
            }
            if (this.radioString.Checked)
            {
                this.SetMaterial(Materials.String);
            }
            if (this.radioMochi.Checked)
            {
                this.SetMaterial(Materials.Mochi);
            }
            if (this.radioFire.Checked)
            {
                this.SetMaterial(Materials.Fire);
            }
            if (this.radioPowder.Checked)
            {
                this.SetMaterial(Materials.Powder);
            }
            if (this.radioFuel.Checked)
            {
                this.SetMaterial(Materials.Fuel);
            }
            if (this.radioTensil.Checked)
            {
                this.SetMaterial(Materials.Tensile);
            }
            if (this.radioVisco.Checked)
            {
                this.SetMaterial(Materials.Viscous);
            }
            if (this.radioRice.Checked)
            {
                this.SetMaterial(Materials.Kome);
            }
            if (this.radioGas.Checked)
            {
                this.SetMaterial(Materials.Gas);
            }
            if (this.radioHot.Checked)
            {
                this.SetMaterial(Materials.Hot);
            }
            if (this.radioCold.Checked)
            {
                this.SetMaterial(Materials.Cold);
            }
            if (this.radioFlow.Checked)
            {
                this.SetMaterial(Materials.Inflow);
            }
            if (this.radioOut.Checked)
            {
                this.SetMaterial(Materials.Outflow);
            }
            if (this.radioAxis.Checked)
            {
                this.SetMaterial(Materials.Axis);
            }
            if (this.radioOil.Checked)
            {
                this.SetMaterial(Materials.Light);
            }
            if (this.radioUsers.Checked)
            {   
                this.SetMaterial(Materials.Users);
            }
            if (this.radioBrittle.Checked)
            {
                this.SetMaterial(Materials.Brittle);
            }
            if (this.radioBlank0.Checked)
            {
                this.SetMaterial(Materials.Yuki);
            }
            if (this.radioZombie.Checked)
            {
                this.SetMaterial(Materials.NoMaterial);
                this.SetParticleInfo(ParticleInfoManaged.Zombie);
            }
            if (this.radioDense.Checked)
            {
                this.SetMaterial(Materials.Dense);
            }
            if (this.radioLight.Checked)
            {
                this.SetMaterial(Materials.NoMaterial);
                this.SetParticleInfo(ParticleInfoManaged.Light);
                this.SetColor(lightColor);
            }
            if (this.radioJet.Checked)
            {
                particleInfoManaged = ParticleInfoManaged.Rigid | ParticleInfoManaged.Jet;
                this.SetMaterial(Materials.NoMaterial);
                this.SetParticleInfo(particleInfoManaged);
                this.SetColor(jetColor);
            }
            this.SetColor(this.FromMColor(this.panelController.NextColor));
            this.GetPanelController().Config.ReadValue("pouringMaterial", (int)this.panelController.NextMaterial);
        }

        public void SetButtons(Materials mate, ParticleInfoManaged info)
        {
            if (mate != Materials.Fire)
            {
                switch (mate)
                {
                    case Materials.Brittle:
                        this.radioBrittle.Checked = true;
                        break;
                    case Materials.Cold:
                        this.radioCold.Checked = true;
                        break;
                    case Materials.Elastic:
                        this.radioErastic.Checked = true;
                        break;
                    case Materials.Fuel:
                        this.radioFuel.Checked = true;
                        break;
                    case Materials.Gas:
                        this.radioGas.Checked = true;
                        break;
                    case Materials.Hot:
                        this.radioHot.Checked = true;
                        break;
                    case Materials.Inflow:
                        this.radioFlow.Checked = true;
                        break;
                    case Materials.Kome:
                        this.radioRice.Checked = true;
                        break;
                    case Materials.Light:
                        this.radioOil.Checked = true;
                        break;
                    case Materials.Mochi:
                        this.radioMochi.Checked = true;
                        break;
                    case Materials.Outflow:
                        this.radioOut.Checked = true;
                        break;
                    case Materials.Powder:
                        this.radioPowder.Checked = true;
                        break;
                    case Materials.Aqua:
                        this.radioAqua.Checked = true;
                        break;
                    case Materials.Rigid:
                        this.radioRigid.Checked = true;
                        break;
                    case Materials.String:
                        this.radioString.Checked = true;
                        break;
                    case Materials.Tensile:
                        this.radioTensil.Checked = true;
                        break;
                    case Materials.Users:
                        this.radioUsers.Checked = true;
                        break;
                    case Materials.Viscous:
                        this.radioVisco.Checked = true;
                        break;
                    case Materials.Wall:
                        this.radioWall.Checked = true;
                        break;
                    case Materials.Axis:
                        this.radioAxis.Checked = true;
                        break;
                    case Materials.Yuki:
                        this.radioBlank0.Checked = true;
                        break;
                }
            }
            else
            {
                this.radioFire.Checked = true;
            }
            if ((info & ParticleInfoManaged.Aqua) != ParticleInfoManaged.None)
            {
                this.checkWater.Checked = true;
            }
            else
            {
                this.checkWater.Checked = false;
            }
            if ((info & ParticleInfoManaged.Mochi) != ParticleInfoManaged.None)
            {
                this.checkMochi.Checked = true;
            }
            else
            {
                this.checkMochi.Checked = false;
            }
            if ((info & ParticleInfoManaged.Spring) != ParticleInfoManaged.None)
            {
                this.checkString.Checked = true;
            }
            else
            {
                this.checkString.Checked = false;
            }
            if ((info & ParticleInfoManaged.Elastic) != ParticleInfoManaged.None)
            {
                this.checkElastic.Checked = true;
            }
            else
            {
                this.checkElastic.Checked = false;
            }
            if ((info & ParticleInfoManaged.Rigid) != ParticleInfoManaged.None)
            {
                this.checkSolid.Checked = true;
            }
            else
            {
                this.checkSolid.Checked = false;
            }
            if ((info & ParticleInfoManaged.Wall) != ParticleInfoManaged.None)
            {
                this.checkWall.Checked = true;
            }
            else
            {
                this.checkWall.Checked = false;
            }
            if ((info & ParticleInfoManaged.Zombie) != ParticleInfoManaged.None)
            {
                this.checkZombie.Checked = true;
                this.radioZombie.Checked = true;
            }
            else
            {
                this.checkZombie.Checked = false;
                this.radioZombie.Checked = false;
            }
            if ((info & ParticleInfoManaged.Brittle) != ParticleInfoManaged.None)
            {
                this.checkBrittle.Checked = true;
            }
            else
            {
                this.checkBrittle.Checked = false;
            }
            if ((info & ParticleInfoManaged.Users) != ParticleInfoManaged.None)
            {
                this.checkUsers.Checked = true;
            }
            else
            {
                this.checkUsers.Checked = false;
            }
            if ((info & ParticleInfoManaged.Dense) != ParticleInfoManaged.None)
            {
                this.checkHeavy.Checked = true;
            }
            else
            {
                this.checkHeavy.Checked = false;
            }
            if ((info & ParticleInfoManaged.Light) != ParticleInfoManaged.None)
            {
                this.checkLight.Checked = true;
            }
            else
            {
                this.checkLight.Checked = false;
            }
            if ((info & ParticleInfoManaged.Axis) != ParticleInfoManaged.None)
            {
                this.checkAxis.Checked = true;
            }
            else
            {
                this.checkAxis.Checked = false;
            }
            if ((info & ParticleInfoManaged.Outflow) != ParticleInfoManaged.None)
            {
                this.checkOut.Checked = true;
            }
            else
            {
                this.checkOut.Checked = false;
            }
            if ((info & ParticleInfoManaged.Inflow) != ParticleInfoManaged.None)
            {
                this.checkFlow.Checked = true;
            }
            else
            {
                this.checkFlow.Checked = false;
            }
            if ((info & ParticleInfoManaged.Cold) != ParticleInfoManaged.None)
            {
                this.checkCold.Checked = true;
            }
            else
            {
                this.checkCold.Checked = false;
            }
            if ((info & ParticleInfoManaged.Hot) != ParticleInfoManaged.None)
            {
                this.checkHot.Checked = true;
            }
            else
            {
                this.checkHot.Checked = false;
            }
            if ((info & ParticleInfoManaged.Gas) != ParticleInfoManaged.None)
            {
                this.checkGas.Checked = true;
            }
            else
            {
                this.checkGas.Checked = false;
            }
            if ((info & ParticleInfoManaged.Kome) != ParticleInfoManaged.None)
            {
                this.checkRice.Checked = true;
            }
            else
            {
                this.checkRice.Checked = false;
            }
            if ((info & ParticleInfoManaged.Viscous) != ParticleInfoManaged.None)
            {
                this.checkVisco.Checked = true;
            }
            else
            {
                this.checkVisco.Checked = false;
            }
            if ((info & ParticleInfoManaged.Tensile) != ParticleInfoManaged.None)
            {
                this.checkTensil.Checked = true;
            }
            else
            {
                this.checkTensil.Checked = false;
            }
            if ((info & ParticleInfoManaged.Fuel) != ParticleInfoManaged.None)
            {
                this.checkFuel.Checked = true;
            }
            else
            {
                this.checkFuel.Checked = false;
            }
            if ((info & ParticleInfoManaged.Storable) != ParticleInfoManaged.None)
            {
                this.StorableButton.Checked = true;
            }
            else
            {
                this.StorableButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Textured) != ParticleInfoManaged.None)
            {
                this.TexturedButton.Checked = true;
            }
            else
            {
                this.TexturedButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Selected) != ParticleInfoManaged.None)
            {
                this.SelectedButton.Checked = true;
            }
            else
            {
                this.SelectedButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Linked) != ParticleInfoManaged.None)
            {
                this.checkLink.Checked = true;
            }
            else
            {
                this.checkLink.Checked = false;
            }
            if ((info & ParticleInfoManaged.Joinable) != ParticleInfoManaged.None)
            {
                this.JoinableButton.Checked = true;
            }
            else
            {
                this.JoinableButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Natural) != ParticleInfoManaged.None)
            {
                this.NaturalButton.Checked = true;
            }
            else
            {
                this.NaturalButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Jet) != ParticleInfoManaged.None)
            {
                this.radioJet.Checked = true;
                this.JetButton.Checked = true;
            }
            else
            {
                this.radioJet.Checked = false;
                this.JetButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Air) != ParticleInfoManaged.None)
            {
                this.AirButton.Checked = true;
            }
            else
            {
                this.AirButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Reserved) != ParticleInfoManaged.None)
            {
                this.ReservedButton.Checked = true;
            }
            else
            {
                this.ReservedButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.None) != ParticleInfoManaged.None)
            {
                this.NoneButton.Checked = true;
            }
            else
            {
                this.NoneButton.Checked = false;
            }
            if ((info & ParticleInfoManaged.Powder) != ParticleInfoManaged.None)
            {
                this.checkPowder.Checked = true;
                return;
            }
            this.checkPowder.Checked = false;
        }

        private void SetCustomMaterial()
        {
            ParticleInfoManaged particleInfoManaged = ParticleInfoManaged.None;
            if (this.checkWater.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Aqua;
            }
            if (this.checkMochi.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Mochi;
            }
            if (this.checkString.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Spring;
            }
            if (this.checkElastic.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Elastic;
            }
            if (this.checkSolid.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Rigid;
            }
            if (this.checkWall.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Wall;
            }
            if (this.checkZombie.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Zombie;
            }
            if (this.checkBrittle.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Brittle;
            }
            if (this.checkUsers.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Users;
            }
            if (this.checkHeavy.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Dense;
            }
            if (this.checkLight.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Light;
            }
            if (this.checkLink.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Linked;
            }
            if (this.checkAxis.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Axis;
            }
            if (this.checkOut.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Outflow;
            }
            if (this.checkFlow.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Inflow;
            }
            if (this.checkCold.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Cold;
            }
            if (this.checkHot.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Hot;
            }
            if (this.checkGas.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Gas;
            }
            if (this.checkRice.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Kome;
            }
            if (this.checkVisco.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Viscous;
            }
            if (this.checkTensil.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Tensile;
            }
            if (this.checkFuel.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Fuel;
            }
            if (this.checkPowder.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Powder;
            }
            if (this.checkBox12.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Yuki;
            }
            if (this.StorableButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Storable;
            }
            if (this.TexturedButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Textured;
            }
            if (this.SelectedButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Selected;
            }
            if (this.JoinableButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Joinable;
            }
            if (this.NaturalButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Natural;
            }
            if (this.JetButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Jet;
            }
            if (this.AirButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Air;
            }
            if (this.ReservedButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Reserved;
            }
            if (this.NoneButton.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.None;
            }
            this.SetParticleInfo(particleInfoManaged);
            this.SetColor(this.FromMColor(this.panelController.NextColor));
        }

        private PanelController panelController;
        private BrowserForm BrowserWindow;
        private PropertyForm PropertyWindow;
        private TimeForm TimeWindow;
        private StatusForm StatusWindow;
        private ParametersForm ParametersWindow;
        private MaterialNames MaterialNameList;
        private int DylanWasHere = 277;
        public string SceneTitle;
        public string SceneDescription;
        public string SceneTags;
        public string SceneID;
        public string SceneUserID;
        public string SceneParentID;
        public string SceneAPGID;
        private string ImagePath;
        public bool PublishFlag;
        public bool UseScript;
        public bool EnableTag;
        private byte[] LastLoadData;
        public bool ToolLimit;

        private void Topmost_CheckChanged(object sender, EventArgs e)
        {
            this.TopMost = topmostToolStripMenuItem.Checked;
        }

        public void UpdateUI()
        {
            this.checkBoxPause.Checked = this.panelController.Config.PauseFlag;
            this.checkBoxDrain.Checked = !this.panelController.Config.BoundsFlag;
            this.checkBoxSplash.Checked = this.panelController.Config.SplashFlag;
            this.checkBoxBubble.Checked = this.panelController.Config.BubbleFlag;
            this.checkBoxGravity.Checked = this.panelController.Config.GravityFlag;
            this.checkBoxPouring.Checked = this.panelController.Config.PouringFlag;
            this.trackBarGravity.Value = Math.Max(1, Math.Min(1000, (int)((float)this.panelController.Config.GravityAcceleration * 2000000f)));
            this.trackBarPouring.Value = Math.Max(1, Math.Min(1000, (int)((float)this.panelController.Config.PouringVelocity * 5000f)));
            this.textBoxAlpha.Text = this.trackBarAlpha.Value.ToString();
            this.SetcomboBoxStyle();
        }

        private void OECCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.panelController.Config.PauseFlag = this.checkBoxPause.Checked;
            this.panelController.Config.BoundsFlag = !this.checkBoxDrain.Checked;
            this.panelController.Config.SplashFlag = this.checkBoxSplash.Checked;
            this.panelController.Config.BubbleFlag = this.checkBoxBubble.Checked;
            this.panelController.Config.GravityFlag = this.checkBoxGravity.Checked;
            this.panelController.Config.PouringFlag = this.checkBoxPouring.Checked;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.panelController.Config.GravityAcceleration = (float)this.trackBarGravity.Value / 2000000f;         
        }

        private void trackBarPouring_ValueChanged(object sender, EventArgs e)
        {
            this.GetPanelController().Config.ReadValue("pouringThickness", this.trackBarPouring.Value / 200f);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.RegisterUndo();
            this.panelController.Scene.particleBuilder.EraseParticles(ParticleInfoManaged.None);
            this.panelController.Scene.Clear();
            this.GetPanelController().Config.BoundsWidth = this.panel1.Width / this.GetPanelController().Config.Scale;
            this.GetPanelController().Config.BoundsHeight = this.panel1.Height / this.GetPanelController().Config.Scale;
            this.UpdateUI();
            this.trackBarGravity.Value = 800;
            this.panelController.Config.GravityAcceleration = (float)this.trackBarGravity.Value / 2000000f;
            this.panelController.Config.PouringVelocity = (float)this.trackBarPouring.Value / 5000f;
            this.panelController.Config.TimeStepsPerFrame = 8;
            this.panelController.Config.SoundFlag = false;
            this.GetPanelController().panelOECMain.Focus();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            this.panelController.Undo();
            this.GetPanelController().panelOECMain.Focus();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            this.panelController.Scene.Redo();
            this.GetPanelController().panelOECMain.Focus();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = this.FromMColor(this.panelController.NextColor);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.SetColor(colorDialog.Color);
            }
            this.GetPanelController().panelOECMain.Focus();
        }

        private void OECToolButton_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioBrush.Checked)
            {
                this.SetTool(Tools.BrushTool);
            }
            if (this.radioPencil.Checked)
            {
                this.SetTool(Tools.PencilTool);
            }
            if (this.radioShape.Checked)
            {
                this.SetTool(Tools.ShapeTool);
            }
            if (this.radioBucket.Checked)
            {
                this.SetTool(Tools.BucketTool);
            }
            if (this.radioMove.Checked)
            {
                this.SetTool(Tools.MoveTool);
            }
            if (this.radioEraser.Checked)
            {
                this.SetTool(Tools.EraserTool);
            }
            if (this.radioReplace.Checked)
            {
                this.SetTool(Tools.MaterialTool);
            }
            if (this.radioSpuit.Checked)
            {
                this.SetTool(Tools.SamplerTool);
            }
            if (this.radioArrow.Checked)
            {
                this.SetTool(Tools.ArrowTool);
            }
            if (this.radioSlice.Checked)
            {
                this.SetTool(Tools.SliceTool);
            }
            if (this.radioSelect.Checked)
            {
                this.SetTool(Tools.MarqueeTool);
            }
            if (this.radioMarker.Checked)
            {
                this.SetTool(Tools.MarkerTool);
            }
            if (this.radioChgColor.Checked)
            {
                this.SetTool(Tools.ColorTool);
            }
            if (this.radioLink.Checked)
            {
                this.SetTool(Tools.LinkTool);
            }
            if (this.radioToolAxis.Checked)
            {
                this.SetTool(Tools.AxisTool);
            }
            if (this.radioControl.Checked)
            {
                this.SetTool(Tools.ControlTool);
            }
            this.SetColor(this.FromMColor(this.panelController.NextColor));
            this.panelController.LastTool = this.panelController.LeftButtonTool;
            this.GetPanelController().panelOECMain.Focus();
        }

        private void comboBoxStyle_TextChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxStyle.Text)
            {
                case "Points":
                    this.panelController.Config.RenderMode = 1;
                    break;
                case "Crosses":
                    this.panelController.Config.RenderMode = 2;
                    break;
                case "Circles":
                    this.panelController.Config.RenderMode = 3;
                    break;
                case "Blurred":
                    this.panelController.Config.RenderMode = 4;
                    break;
                case "Contour":
                    this.panelController.Config.RenderMode = 5;
                    break;
                case "Texture":
                    this.panelController.Config.RenderMode = 6;
                    break;
            }
            this.GetPanelController().panelOECMain.Focus();
        }

        private void SetcomboBoxStyle()
        {
            switch (this.panelController.Config.RenderMode)
            {
                case 1:
                    this.comboBoxStyle.Text = "Points";
                    break;
                case 2:
                    this.comboBoxStyle.Text = "Crosses";
                    break;
                case 3:
                    this.comboBoxStyle.Text = "Circles";
                    break;
                case 4:
                    this.comboBoxStyle.Text = "Blurred";
                    break;
                case 5:
                    this.comboBoxStyle.Text = "Contour";
                    break;
                case 6:
                    this.comboBoxStyle.Text = "Texture";
                    break;
            }
            this.Focus();
        }
  
        private TextureManaged LoadTexture()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.ImagePath = this.openFileDialog1.FileName.Replace('\\', '/');
                    Bitmap bitmap = new Bitmap(this.ImagePath);
                    byte[] array = CommonMethod.LimitedImageData(bitmap, 16384, 16384);
                    if (array.Length != 0)
                    {
                        this.GetPanelController().beat.SetFileResource(this.ImagePath, array);
                        return this.GetPanelController().Scene.Scene.FileManager.GetTextureFromFileSystem(Path.GetFileName(this.ImagePath));
                    }
                }
                catch (Exception)
                {
                }
            }
            return null;
        }

        private void buttonForeground_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.ForegroundTexture = textureManaged;
        }

        private void buttonUnloadFore_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.ForegroundTexture = null;
        }

        private void buttonUnloadBack_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.BackgroundTexture = null;
        }

        private void buttonUnloadFire_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.FireTexture = null;
        }

        private void buttonUnloadSplash_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.SplashTexture = null;
        }

        private void buttonUnloadBubble_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.BubbleTexture = null;
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.BackgroundTexture = textureManaged;
        }

        private void buttonFireTexture_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.FireTexture = textureManaged;
        }

        private void buttonSplashTexture_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.SplashTexture = textureManaged;
        }

        private void buttonBubbleTexture_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.BubbleTexture = textureManaged;
        }

        private void buttonWatermark_Click(object sender, EventArgs e)
        {
            TextureManaged textureManaged = this.LoadTexture();
            this.GetPanelController().Config.WatermarkTexture = textureManaged;
        }

        private void buttonUnloadWatermark_Click(object sender, EventArgs e)
        {
            this.GetPanelController().Config.WatermarkTexture = null;
        }

        private void tabControlMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlMaterials.SelectedTab == this.tabPageBasic)
            {
                this.tabControlMaterials.Size = new Size(235, 213);
                this.groupBoxBasic.Size = new Size(239, 234);
                this.groupBoxScene.Location = new Point(5, 238);
                this.groupBoxTool.Location = new Point(5, 378);
                this.groupBoxGraphical.Location = new Point(5, 505);
                this.GetPanelController().panelOECMain.Focus();
                return;
            }
            this.tabControlMaterials.Size = new Size(235, 265);
            this.groupBoxBasic.Size = new Size(239, 286);
            this.groupBoxScene.Location = new Point(5, 291);
            this.groupBoxTool.Location = new Point(5, 431);
            this.groupBoxGraphical.Location = new Point(5, 556);
            this.GetPanelController().panelOECMain.Focus();
        }

        private void gCCollectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void FocusPanel1(object sender, EventArgs e)
        {
            this.GetPanelController().panelOECMain.Focus();
        }

        private void trackBarMouseUP(object sender, MouseEventArgs e)
        {
            if (this.ParametersWindow != null)
            {
                this.ParametersWindow.RefreshValues();
            }
            this.GetPanelController().panelOECMain.Focus();
        }

        private void trackBarAlpha_Scroll(object sender, EventArgs e)
        {
            this.textBoxAlpha.Text = this.trackBarAlpha.Value.ToString();
            this.SetColor(this.FromMColor(this.panelController.NextColor));
        }

        private void hideSidePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.hideSidePanelToolStripMenuItem.Checked)
            {
                this.DylanWasHere = 16;
                this.FormResize(0, 0, false, true);
                this.hideSidePanelToolStripMenuItem.Text = "Unhide side panel";
                return;
            }
            this.DylanWasHere = 277;
            if (this.WindowState == FormWindowState.Maximized) {this.GetPanelController().Config.BoundsWidth = (float)(int)(this.Width - DylanWasHere) / this.GetPanelController().Config.Scale;}
            this.FormResize(0, 0, true, false);
            this.hideSidePanelToolStripMenuItem.Text = "Hide side panel";
        }

        private void FixForm()
        {
            this.GetPanelController().Config.BoundsWidth = this.panel1.Width / this.GetPanelController().Config.Scale;
            this.GetPanelController().Config.BoundsHeight = this.panel1.Height / this.GetPanelController().Config.Scale;
            this.GetPanelController().Config.SoundFlag = playSoundToolStripMenuItem.Checked;
            this.UpdateUI();
            this.trackBarGravity.Value = 800;
            this.panelController.Config.GravityAcceleration = (float)this.trackBarGravity.Value / 2000000f;
            this.panelController.Config.PouringVelocity = (float)this.trackBarPouring.Value / 5000f;
            this.panelController.Config.TimeStepsPerFrame = 8;
            if (this.BrowserWindow != null)
            {
                this.BrowserWindow.UpdateParam();
            }
            if (this.DylanWasHere == 16) { this.Size = new Size(816, 763); } else { this.Size = new Size(1077, 763); }
            this.FormResize(0, 0, false, false);
        }
    }
}
