﻿// Decompiled with JetBrains decompiler
// Type: TLO.local.SettingsForm
// Assembly: TLO.local, Version=2.6.5944.27906, Culture=neutral, PublicKeyToken=null
// MVID: E76CFDB0-1920-4151-9DD8-5FF51DE7CC23
// Assembly location: C:\Users\root\Downloads\TLO_2.6.2.21\TLO.local.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TLO.local
{
    public class SettingsForm : Form
    {
        private BindingSource _TorrentClientsSource = new BindingSource();
        private BindingSource _CategoriesSource = new BindingSource();
        private IContainer components;
        private Button _btCheck;
        private Button _btCancel;
        private Button _btSave;
        private TabPage _tpCategories;
        private Panel panel1;
        private GroupBox groupBox7;
        private ComboBox _cbSubFolder;
        private Label label22;
        private Button _CategoriesBtSelectFolder;
        private Label label18;
        private TextBox _CategoriesTbFolderDownloads;
        private Label label16;
        private ComboBox _CategoriesCbStartCountSeeders;
        private Label label15;
        private GroupBox groupBox6;
        private TextBox _CategoriesTbFullName;
        private Label label14;
        private TextBox _CategoriesTbCategoryID;
        private Label label13;
        private Button _btCategoryRemove;
        private Button _btCategoryAdd;
        private DataGridView dgwCategories;
        private DataGridViewTextBoxColumn ColumnCategoryCategoryID;
        private DataGridViewTextBoxColumn ColumnCategoryName;
        private TabPage tbpTorrentClients;
        private GroupBox groupBox5;
        private Button _btTorrentClientAdd;
        private Button _btTorrentClientDelete;
        private GroupBox groupBox3;
        private TextBox _tbTorrentClientHostIP;
        private Label label7;
        private Label label6;
        private TextBox _tbTorrentClientUserPassword;
        private TextBox _tbTorrentClientUserName;
        private TextBox _tbTorrentClientPort;
        private Label label5;
        private DataGridView dgwTorrentClients;
        private DataGridViewTextBoxColumn UID;
        private DataGridViewTextBoxColumn FolderName;
        private ComboBox _cbTorrentClientType;
        private Label label2;
        private Label label1;
        private TextBox _tbTorrentClientName;
        private TabControl tabControl1;
        private ComboBox _CategoriesCbTorrentClient;
        private Label label3;
        private CheckBox _cbIsSaveTorrentFile;
        private CheckBox _cbIsSaveWebPage;
        private TabPage tabPage1;
        private ForumPages forumPages1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox _appKeeperPass;
        private TextBox _appKeeperName;
        private Label label4;
        private GroupBox groupBox2;
        private CheckBox _appIsAvgCountSeeders;
        private Label label10;
        private GroupBox groupBox4;
        private NumericUpDown _appPeriodRunAndStopTorrents;
        private Label label11;
        private Label label12;
        private CheckBox _appIsUpdateStatistics;
        private NumericUpDown _appCountDaysKeepHistory;
        private Label label19;
        private NumericUpDown _appCountSeedersReport;
        private Label label20;
        private CheckBox _appSelectLessOrEqual;
        private NumericUpDown _appLogLevel;
        private Label label21;
        private Label label23;
        private RadioButton _tcrbRemote;
        private RadioButton _tcrbCurrent;
        private CheckBox _appIsNotSaveStatistics;
        private GroupBox groupBox8;
        private Label label9;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private TextBox _appReportLine;
        private Label label17;
        private Label label29;
        private Label label28;
        private Label label32;
        private TextBox _appReportBottom;
        private Label label31;
        private Label label30;
        private TextBox _appReportTop2;
        private TextBox _appReportTop1;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label38;
        private Label label37;
        private Label label39;
        private TextBox _CategoriesTbLabel;
        private Label label40;
        private TabPage _tpAllCategories;
        private CheckBox _dbLoadInMemoryCheckbox;
        private Panel panel2;

        public SettingsForm()
        {
            this.InitializeComponent();
            this._tbTorrentClientName.Enabled = false;
            this._cbTorrentClientType.Enabled = false;
            this._tbTorrentClientHostIP.Enabled = false;
            this._tbTorrentClientPort.Enabled = false;
            this._tbTorrentClientUserName.Enabled = false;
            this._tbTorrentClientUserPassword.Enabled = false;
            this.dgwTorrentClients.AutoGenerateColumns = false;
            this.dgwTorrentClients.ClearSelection();
            this.dgwTorrentClients.DataSource = (object) null;
            this._TorrentClientsSource = new BindingSource();
            this._TorrentClientsSource.DataSource = (object) ClientLocalDB.Current.GetTorrentClients();
            this.dgwTorrentClients.DataSource = (object) this._TorrentClientsSource;
            this.dgwCategories.AutoGenerateColumns = false;
            this.dgwCategories.ClearSelection();
            this.dgwCategories.DataSource = (object) null;
            this._CategoriesSource = new BindingSource();
            this._CategoriesSource.DataSource = (object) ClientLocalDB.Current.GetCategoriesEnable();
            this.dgwCategories.DataSource = (object) this._CategoriesSource;
            if (this._CategoriesSource.Count > 0)
                this._CategoriesSource.Position = 0;
            if (this._TorrentClientsSource.Count > 0)
                this._TorrentClientsSource.Position = 0;
            this.forumPages1.LoadSettings();
            CreatePageAllCategories();
            Settings current = Settings.Current;
            this._appKeeperName.Text = current.KeeperName;
            this._appKeeperPass.Text = current.KeeperPass;
            this._appIsUpdateStatistics.Checked = current.IsUpdateStatistics;
            this._appCountDaysKeepHistory.Value = (Decimal) current.CountDaysKeepHistory;
            this._appPeriodRunAndStopTorrents.Value = (Decimal) current.PeriodRunAndStopTorrents;
            this._appCountSeedersReport.Value = (Decimal) current.CountSeedersReport;
            this._appIsAvgCountSeeders.Checked = current.IsAvgCountSeeders;
            this._appSelectLessOrEqual.Checked = current.IsSelectLessOrEqual;
            {
                CheckState checkState;
                if (Settings.Current.LoadDBInMemory == null)
                {
                    checkState = CheckState.Indeterminate;
                }
                else if ((bool)current.LoadDBInMemory)
                {
                    checkState = CheckState.Checked;
                }
                else
                {
                    checkState = CheckState.Unchecked;
                }

                this._dbLoadInMemoryCheckbox.AutoSize = true;
                this._dbLoadInMemoryCheckbox.Checked = current.LoadDBInMemory.GetValueOrDefault(false);
                this._dbLoadInMemoryCheckbox.CheckState = checkState;
            }
            NumericUpDown appLogLevel = this._appLogLevel;
            int? logLevel = current.LogLevel;
            int num1;
            if (!logLevel.HasValue)
            {
                num1 = 0;
            }
            else
            {
                logLevel = current.LogLevel;
                num1 = logLevel.Value;
            }

            Decimal num2 = (Decimal) num1;
            appLogLevel.Value = num2;
            this._appIsNotSaveStatistics.Checked = current.IsNotSaveStatistics;
            this._appReportTop1.Text = current.ReportTop1;
            this._appReportTop2.Text = current.ReportTop2;
            this._appReportLine.Text = current.ReportLine;
            this._appReportBottom.Text = current.ReportBottom;
        }

        private void _Focus_Enter(object sender, EventArgs e)
        {
            if (this._TorrentClientsSource.Current != null)
            {
                TorrentClientInfo current = this._TorrentClientsSource.Current as TorrentClientInfo;
                if (sender == this._tbTorrentClientName)
                    current.Name = this._tbTorrentClientName.Text;
                else if (sender == this._cbTorrentClientType)
                    current.Type = this._cbTorrentClientType.Text;
                else if (sender == this._tbTorrentClientHostIP)
                    current.ServerName = this._tbTorrentClientHostIP.Text;
                else if (sender == this._tbTorrentClientPort)
                {
                    int result = 0;
                    if (int.TryParse(this._tbTorrentClientPort.Text, out result))
                        current.ServerPort = result;
                    else
                        this._tbTorrentClientPort.Text = "0";
                }
                else if (sender == this._tbTorrentClientUserName)
                    current.UserName = this._tbTorrentClientUserName.Text;
                else if (sender == this._tbTorrentClientUserPassword)
                    current.UserPassword = this._tbTorrentClientUserPassword.Text;
                else if (sender == this._tcrbCurrent && this._tcrbCurrent.Checked)
                {
                    current.ServerName = "127.0.0.1";
                    this._tbTorrentClientHostIP.Enabled = false;
                }
                else if (sender == this._tcrbRemote && this._tcrbRemote.Checked)
                {
                    current.ServerName = this._tbTorrentClientHostIP.Text;
                    this._tbTorrentClientHostIP.Enabled = true;
                }
            }

            if (this._CategoriesSource.Current == null)
                return;
            Category current1 = this._CategoriesSource.Current as Category;
            if (sender == this._CategoriesCbTorrentClient)
            {
                TorrentClientInfo selectedItem = this._CategoriesCbTorrentClient.SelectedItem as TorrentClientInfo;
                if (selectedItem == null)
                    return;
                current1.TorrentClientUID = selectedItem.UID;
            }
            else if (sender == this._CategoriesCbStartCountSeeders)
            {
                int result = 0;
                if (!int.TryParse(this._CategoriesCbStartCountSeeders.SelectedItem as string, out result))
                    return;
                current1.CountSeeders = result;
            }
            else if (sender == this._CategoriesTbFolderDownloads)
                current1.Folder = this._CategoriesTbFolderDownloads.Text;
            else if (sender == this._cbIsSaveTorrentFile)
                current1.IsSaveTorrentFiles = this._cbIsSaveTorrentFile.Checked;
            else if (sender == this._cbIsSaveWebPage)
                current1.IsSaveWebPage = this._cbIsSaveWebPage.Checked;
            else if (sender == this._cbSubFolder)
            {
                string selectedItem = this._cbSubFolder.SelectedItem as string;
                if (string.IsNullOrWhiteSpace(selectedItem))
                    return;
                if (!(selectedItem == "Не нужен"))
                {
                    if (!(selectedItem == "С ID топика"))
                    {
                        if (!(selectedItem == "Запрашивать"))
                            return;
                        current1.CreateSubFolder = 2;
                    }
                    else
                        current1.CreateSubFolder = 1;
                }
                else
                    current1.CreateSubFolder = 0;
            }
            else
            {
                if (sender != this._CategoriesTbLabel)
                    return;
                current1.Label = string.IsNullOrWhiteSpace(this._CategoriesTbLabel.Text)
                    ? current1.FullName
                    : this._CategoriesTbLabel.Text.Trim();
            }
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (sender == this.dgwTorrentClients)
            {
                if (this._TorrentClientsSource.Current == null)
                {
                    this._tbTorrentClientName.Enabled = false;
                    this._cbTorrentClientType.Enabled = false;
                    this._tbTorrentClientHostIP.Enabled = false;
                    this._tbTorrentClientPort.Enabled = false;
                    this._tbTorrentClientUserName.Enabled = false;
                    this._tbTorrentClientUserPassword.Enabled = false;
                    this._tbTorrentClientName.Text = string.Empty;
                    this._cbTorrentClientType.Text = string.Empty;
                    this._tbTorrentClientHostIP.Text = string.Empty;
                    this._tbTorrentClientPort.Text = string.Empty;
                    this._tbTorrentClientUserName.Text = string.Empty;
                    this._tbTorrentClientUserPassword.Text = string.Empty;
                    this._tcrbRemote.Checked = false;
                    this._tcrbCurrent.Checked = true;
                    this._tbTorrentClientHostIP.Enabled = false;
                }
                else
                {
                    TorrentClientInfo current = this._TorrentClientsSource.Current as TorrentClientInfo;
                    this._tbTorrentClientName.Enabled = true;
                    this._cbTorrentClientType.Enabled = true;
                    this._tbTorrentClientHostIP.Enabled = true;
                    this._tbTorrentClientPort.Enabled = true;
                    this._tbTorrentClientUserName.Enabled = true;
                    this._tbTorrentClientUserPassword.Enabled = true;
                    this._tbTorrentClientName.Text = current.Name;
                    this._cbTorrentClientType.Text = current.Type;
                    if (current.ServerName == "127.0.0.1")
                    {
                        this._tcrbRemote.Checked = false;
                        this._tcrbCurrent.Checked = true;
                    }
                    else
                    {
                        this._tbTorrentClientHostIP.Text = current.ServerName;
                        this._tcrbCurrent.Checked = false;
                        this._tcrbRemote.Checked = true;
                    }

                    this._tbTorrentClientPort.Text = current.ServerPort.ToString();
                    this._tbTorrentClientUserName.Text = current.UserName;
                    this._tbTorrentClientUserPassword.Text = current.UserPassword;
                }
            }

            if (sender == this.dgwCategories)
            {
                if (this._CategoriesSource.Current == null)
                {
                    this._CategoriesTbCategoryID.Text = string.Empty;
                    this._CategoriesTbFullName.Text = string.Empty;
                    this._CategoriesCbStartCountSeeders.Enabled = false;
                    this._CategoriesTbLabel.Text = string.Empty;
                }
                else
                {
                    Category obj = this._CategoriesSource.Current as Category;
                    this._CategoriesTbCategoryID.Text = obj.CategoryID.ToString();
                    this._CategoriesTbFullName.Text = obj.FullName;
                    this._CategoriesCbStartCountSeeders.Enabled = true;
                    ComboBox startCountSeeders = this._CategoriesCbStartCountSeeders;
                    int num;
                    string str;
                    if (obj.CountSeeders < 0)
                    {
                        str = "-";
                    }
                    else
                    {
                        num = obj.CountSeeders;
                        str = num.ToString();
                    }

                    startCountSeeders.SelectedItem = (object) str;
                    this._CategoriesTbFolderDownloads.Text = obj.Folder;
                    this._CategoriesCbTorrentClient.DataSource = (object) null;
                    this._CategoriesCbTorrentClient.DataSource = this._TorrentClientsSource.DataSource;
                    this._CategoriesCbTorrentClient.SelectedItem =
                        (object) (this._CategoriesCbTorrentClient.DataSource as List<TorrentClientInfo>)
                        .Where<TorrentClientInfo>((Func<TorrentClientInfo, bool>) (x => x.UID == obj.TorrentClientUID))
                        .FirstOrDefault<TorrentClientInfo>();
                    num = obj.CreateSubFolder;
                    switch (num)
                    {
                        case 0:
                            this._cbSubFolder.SelectedItem = (object) "Не нужен";
                            break;
                        case 1:
                            this._cbSubFolder.SelectedItem = (object) "С ID топика";
                            break;
                        case 2:
                            this._cbSubFolder.SelectedItem = (object) "Запрашивать";
                            break;
                    }

                    this._cbIsSaveWebPage.Checked = obj.IsSaveWebPage;
                    this._cbIsSaveTorrentFile.Checked = obj.IsSaveTorrentFiles;
                    this._CategoriesTbLabel.Text = string.IsNullOrWhiteSpace(obj.Label) ? obj.FullName : obj.Label;
                }
            }

            if (sender != this._appIsNotSaveStatistics)
                return;
            if (this._appIsNotSaveStatistics.Checked)
            {
                this._appIsUpdateStatistics.Checked = false;
                this._appIsUpdateStatistics.Enabled = false;
            }
            else
                this._appIsUpdateStatistics.Enabled = true;
        }

        private bool hasChanges = false;

        private void ClickButtons(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (sender == this._btTorrentClientAdd)
                {
                    this._TorrentClientsSource.Add((object) new TorrentClientInfo());
                    this._TorrentClientsSource.Position = this._TorrentClientsSource.Count;
                }
                else if (sender == this._btTorrentClientDelete)
                {
                    if (this._TorrentClientsSource.Current == null)
                        return;
                    TorrentClientInfo current = this._TorrentClientsSource.Current as TorrentClientInfo;
                    if (MessageBox.Show("Вы хотите удалить из списка torrent-клиент \"" + current.Name + "\"?",
                            "Запрос подтверждения", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) ==
                        DialogResult.Yes)
                        this._TorrentClientsSource.Remove((object) current);
                }
            }
            catch
            {
            }

            if (sender == this._dbLoadInMemoryCheckbox)
            {
                hasChanges = true;
            }

            try
            {
                if (sender == this._btCategoryAdd)
                {
                    SelectCategory dialog = new SelectCategory();
                    dialog.Read();
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (dialog.SelectedCategories.Count<Category>() > 0)
                        {
                            dialog.SelectedCategories.ForEach((Action<Category>) (x =>
                            {
                                x.IsEnable = true;
                                this._CategoriesSource.Add((object) x);
                            }));
                            this._CategoriesSource.Position = this._CategoriesSource.Count;
                        }

                        if (dialog.SelectedCategory == null)
                            return;
                        if ((this._CategoriesSource.DataSource as List<Category>).Any<Category>(
                            (Func<Category, bool>) (x => x.CategoryID == dialog.SelectedCategory.CategoryID)))
                        {
                            int num = (int) MessageBox.Show("Выбранная категория уже присутствует");
                        }
                        else
                        {
                            dialog.SelectedCategory.IsEnable = true;
                            this._CategoriesSource.Add((object) dialog.SelectedCategory);
                            this._CategoriesSource.Position = this._CategoriesSource.Count;
                        }
                    }
                }
                else if (sender == this._btCategoryRemove)
                {
                    if (this._CategoriesSource.Current == null)
                        return;
                    Category current = this._CategoriesSource.Current as Category;
                    if (MessageBox.Show("Удалить из обработки раздел \"" + current.Name + "\"?", "Подтверждение",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        this._CategoriesSource.Remove((object) current);
                }
                else if (sender == this._CategoriesBtSelectFolder)
                {
                    if (this._CategoriesSource.Current == null)
                        return;
                    Category current = this._CategoriesSource.Current as Category;
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.SelectedPath =
                        string.IsNullOrWhiteSpace(current.Folder) ? "c:\\" : current.Folder;
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        current.Folder = folderBrowserDialog.SelectedPath;
                        this._CategoriesTbFolderDownloads.Text = current.Folder;
                    }
                }
            }
            catch
            {
            }

            try
            {
                if (sender == this._btSave)
                {
                    ClientLocalDB.Current.SaveTorrentClients(
                        (IEnumerable<TorrentClientInfo>)
                        (this._TorrentClientsSource.DataSource as List<TorrentClientInfo>), true);
                    ClientLocalDB.Current.CategoriesSave(
                        (IEnumerable<Category>) (this._CategoriesSource.DataSource as List<Category>), false);
                    this.forumPages1.Save();
                    this.DialogResult = DialogResult.OK;
                    Settings current = Settings.Current;
                    current.KeeperName = this._appKeeperName.Text;
                    current.KeeperPass = this._appKeeperPass.Text;
                    current.IsUpdateStatistics = this._appIsUpdateStatistics.Checked;
                    current.CountDaysKeepHistory = (int) this._appCountDaysKeepHistory.Value;
                    current.PeriodRunAndStopTorrents = (int) this._appPeriodRunAndStopTorrents.Value;
                    current.CountSeedersReport = (int) this._appCountSeedersReport.Value;
                    current.IsAvgCountSeeders = this._appIsAvgCountSeeders.Checked;
                    current.IsSelectLessOrEqual = this._appSelectLessOrEqual.Checked;
                    current.LogLevel = new int?((int) this._appLogLevel.Value);
                    current.IsNotSaveStatistics = this._appIsNotSaveStatistics.Checked;
                    current.ReportTop1 = this._appReportTop1.Text.Replace("\n", "\r\n").Replace("\r\r", "\r");
                    current.ReportTop2 = this._appReportTop2.Text.Replace("\n", "\r\n").Replace("\r\r", "\r");
                    current.ReportLine = this._appReportLine.Text.Replace("\n", "\r\n").Replace("\r\r", "\r");
                    current.ReportBottom = this._appReportBottom.Text.Replace("\n", "\r\n").Replace("\r\r", "\r");
                    if (this._dbLoadInMemoryCheckbox.CheckState != CheckState.Indeterminate)
                    {
                        current.LoadDBInMemory = this._dbLoadInMemoryCheckbox.Checked;
                    }
                    current.Save();
                    ClientLocalDB.Current.SaveToDatabase();
                    this.Close();
                    if (hasChanges)
                    {
                        MessageBox.Show("Для вступления изменений в силу может потребоваться перезапустить программу.",
                            "Внимание");
                    }
                }
                else if (sender == this._btCancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    if (this._btCheck != sender)
                        return;
                    List<string> stringList = new List<string>();
                    foreach (TorrentClientInfo torrentClientInfo in
                        this._TorrentClientsSource.DataSource as List<TorrentClientInfo>)
                    {
                        try
                        {
                            ITorrentClient torrentClient = torrentClientInfo.Create();
                            if (torrentClient == null)
                                stringList.Add(string.Format(
                                    "Торрент-клиент \"{0}\": Не удалось определить тип torrent-клиента",
                                    (object) torrentClientInfo.Name));
                            else
                                torrentClient.Ping();
                        }
                        catch
                        {
                            stringList.Add(string.Format("Не удалось подключиться к торрент-клиенту \"{0}\"",
                                (object) torrentClientInfo.Name));
                        }
                    }

                    foreach (string text in stringList)
                    {
                        int num = (int) MessageBox.Show(text, "Проверка");
                    }

                    int num1 = (int) MessageBox.Show("Подключение к torrent-клиентам проверено.", "Проверка");
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                int num = (int) MessageBox.Show(ex.Message);
            }
        }

        private void CreatePageAllCategories()
        {
            Control control = this.panel2;
            Dictionary<int, Category> dictionary1 = ClientLocalDB.Current.GetCategories()
                .ToDictionary<Category, int, Category>((Func<Category, int>) (x => x.CategoryID),
                    (Func<Category, Category>) (x => x));
            Dictionary<int, Category> categoriesEnable = ClientLocalDB.Current.GetCategoriesEnable()
                .ToDictionary<Category, int, Category>((Func<Category, int>) (x => x.CategoryID),
                    (Func<Category, Category>) (x => x));
            categoriesEnable.ToDictionary<KeyValuePair<int, Category>, int, int>(
                (Func<KeyValuePair<int, Category>, int>) (x => x.Key),
                (Func<KeyValuePair<int, Category>, int>) (x => x.Value.ParentID));
            for (int index = 0; index < 3; ++index)
            {
                foreach (Category category in categoriesEnable.Values.ToArray<Category>())
                {
                    if (!categoriesEnable.ContainsKey(category.ParentID) && dictionary1.ContainsKey(category.ParentID))
                        categoriesEnable.Add(dictionary1[category.ParentID].CategoryID, dictionary1[category.ParentID]);
                }
            }

            for (int index = 0; index < 3; ++index)
            {
                List<Category> list = dictionary1.Values.ToList<Category>();
                foreach (Category category1 in categoriesEnable.Values.ToList<Category>())
                {
                    Category c = category1;
                    foreach (Category category2 in list.Where<Category>((Func<Category, bool>) (x =>
                    {
                        if (!categoriesEnable.ContainsKey(x.CategoryID))
                            return x.ParentID == c.CategoryID;
                        return false;
                    })).ToArray<Category>())
                    {
                        if (!categoriesEnable.ContainsKey(category2.CategoryID) &&
                            dictionary1.ContainsKey(category2.CategoryID))
                            categoriesEnable.Add(category2.CategoryID, category2);
                    }
                }
            }

            Dictionary<int, string> dictionary2 = ClientLocalDB.Current.GetReports(new int?())
                .Where<KeyValuePair<Tuple<int, int>, Tuple<string, string>>>(
                    (Func<KeyValuePair<Tuple<int, int>, Tuple<string, string>>, bool>) (x =>
                    {
                        if (x.Key.Item2 == 0)
                            return (uint) x.Key.Item1 > 0U;
                        return false;
                    })).ToDictionary<KeyValuePair<Tuple<int, int>, Tuple<string, string>>, int, string>(
                    (Func<KeyValuePair<Tuple<int, int>, Tuple<string, string>>, int>) (x => x.Key.Item1),
                    (Func<KeyValuePair<Tuple<int, int>, Tuple<string, string>>, string>) (x => x.Value.Item1));
            int num = 0;
            int y1 = 10;
            foreach (Category category in (IEnumerable<Category>) categoriesEnable.Values.OrderBy<Category, string>(
                (Func<Category, string>) (x => x.FullName)))
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new Point(3, y1);
                label1.Size = new Size(35, 13);
                label1.TabIndex = num;
                label1.Text = category.FullName;
                control.Controls.Add((Control) label1);
                int y2 = y1 + 16;
                Label label2 = new Label();
                label2.Location = new Point(6, y2);
                label2.Size = new Size(123, 20);
                label2.Text = "Списки хранимого";
                control.Controls.Add((Control) label2);
                ++num;
                TextBox textBox = new TextBox();
                textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                textBox.Location = new Point(135, y2);
                textBox.Size = new Size(this.panel1.Size.Width - 135, 20);
                textBox.TabIndex = num;
                textBox.Text =
                    !string.IsNullOrWhiteSpace(category.ReportList) || !dictionary2.ContainsKey(category.CategoryID)
                        ? category.ReportList
                        : dictionary2[category.CategoryID];
                control.Controls.Add((Control) textBox);
                y1 = y2 + 26;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this._btCheck = new System.Windows.Forms.Button();
            this._btCancel = new System.Windows.Forms.Button();
            this._btSave = new System.Windows.Forms.Button();
            this._tpCategories = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this._CategoriesTbLabel = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this._cbIsSaveTorrentFile = new System.Windows.Forms.CheckBox();
            this._cbIsSaveWebPage = new System.Windows.Forms.CheckBox();
            this._CategoriesCbTorrentClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._CategoriesTbFolderDownloads = new System.Windows.Forms.TextBox();
            this._cbSubFolder = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this._CategoriesBtSelectFolder = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this._CategoriesCbStartCountSeeders = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._CategoriesTbFullName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this._CategoriesTbCategoryID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._btCategoryRemove = new System.Windows.Forms.Button();
            this._btCategoryAdd = new System.Windows.Forms.Button();
            this.dgwCategories = new System.Windows.Forms.DataGridView();
            this.ColumnCategoryCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpTorrentClients = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._btTorrentClientAdd = new System.Windows.Forms.Button();
            this._btTorrentClientDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._tcrbRemote = new System.Windows.Forms.RadioButton();
            this._tcrbCurrent = new System.Windows.Forms.RadioButton();
            this._tbTorrentClientHostIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tbTorrentClientUserPassword = new System.Windows.Forms.TextBox();
            this._tbTorrentClientUserName = new System.Windows.Forms.TextBox();
            this._tbTorrentClientPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwTorrentClients = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cbTorrentClientType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._tbTorrentClientName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this._appReportBottom = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this._appReportTop2 = new System.Windows.Forms.TextBox();
            this._appReportTop1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this._appReportLine = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._appCountSeedersReport = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dbLoadInMemoryCheckbox = new System.Windows.Forms.CheckBox();
            this._appIsNotSaveStatistics = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this._appLogLevel = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this._appSelectLessOrEqual = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this._appIsUpdateStatistics = new System.Windows.Forms.CheckBox();
            this._appPeriodRunAndStopTorrents = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._appCountDaysKeepHistory = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this._appIsAvgCountSeeders = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this._appKeeperPass = new System.Windows.Forms.TextBox();
            this._appKeeperName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.forumPages1 = new TLO.local.ForumPages();
            this._tpAllCategories = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this._tpCategories.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).BeginInit();
            this.tbpTorrentClients.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTorrentClients)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appCountSeedersReport)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appLogLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._appPeriodRunAndStopTorrents)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appCountDaysKeepHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this._tpAllCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btCheck
            // 
            this._btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btCheck.Location = new System.Drawing.Point(12, 623);
            this._btCheck.Name = "_btCheck";
            this._btCheck.Size = new System.Drawing.Size(75, 23);
            this._btCheck.TabIndex = 16;
            this._btCheck.Text = "Проверить";
            this._btCheck.UseVisualStyleBackColor = true;
            this._btCheck.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _btCancel
            // 
            this._btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btCancel.Location = new System.Drawing.Point(970, 623);
            this._btCancel.Name = "_btCancel";
            this._btCancel.Size = new System.Drawing.Size(75, 23);
            this._btCancel.TabIndex = 15;
            this._btCancel.Text = "Отмена";
            this._btCancel.UseVisualStyleBackColor = true;
            this._btCancel.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _btSave
            // 
            this._btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btSave.Location = new System.Drawing.Point(889, 623);
            this._btSave.Name = "_btSave";
            this._btSave.Size = new System.Drawing.Size(75, 23);
            this._btSave.TabIndex = 14;
            this._btSave.Text = "Сохранить";
            this._btSave.UseVisualStyleBackColor = true;
            this._btSave.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _tpCategories
            // 
            this._tpCategories.Controls.Add(this.panel1);
            this._tpCategories.Controls.Add(this._btCategoryRemove);
            this._tpCategories.Controls.Add(this._btCategoryAdd);
            this._tpCategories.Controls.Add(this.dgwCategories);
            this._tpCategories.Location = new System.Drawing.Point(4, 22);
            this._tpCategories.Name = "_tpCategories";
            this._tpCategories.Padding = new System.Windows.Forms.Padding(3);
            this._tpCategories.Size = new System.Drawing.Size(1041, 591);
            this._tpCategories.TabIndex = 4;
            this._tpCategories.Text = "Разделы/Подразделы";
            this._tpCategories.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Location = new System.Drawing.Point(254, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 550);
            this.panel1.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this._CategoriesTbLabel);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this._cbIsSaveTorrentFile);
            this.groupBox7.Controls.Add(this._cbIsSaveWebPage);
            this.groupBox7.Controls.Add(this._CategoriesCbTorrentClient);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this._CategoriesTbFolderDownloads);
            this.groupBox7.Controls.Add(this._cbSubFolder);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this._CategoriesBtSelectFolder);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this._CategoriesCbStartCountSeeders);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(3, 122);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(778, 235);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // _CategoriesTbLabel
            // 
            this._CategoriesTbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._CategoriesTbLabel.Location = new System.Drawing.Point(115, 202);
            this._CategoriesTbLabel.Name = "_CategoriesTbLabel";
            this._CategoriesTbLabel.Size = new System.Drawing.Size(657, 20);
            this._CategoriesTbLabel.TabIndex = 15;
            this._CategoriesTbLabel.Enter += new System.EventHandler(this._Focus_Enter);
            this._CategoriesTbLabel.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 205);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(103, 13);
            this.label40.TabIndex = 14;
            this.label40.Text = "Установить метку:";
            // 
            // _cbIsSaveTorrentFile
            // 
            this._cbIsSaveTorrentFile.AutoSize = true;
            this._cbIsSaveTorrentFile.Location = new System.Drawing.Point(9, 156);
            this._cbIsSaveTorrentFile.Name = "_cbIsSaveTorrentFile";
            this._cbIsSaveTorrentFile.Size = new System.Drawing.Size(305, 17);
            this._cbIsSaveTorrentFile.TabIndex = 13;
            this._cbIsSaveTorrentFile.Text = "Сохранять torrent-файлы в подкаталог \"!!!Torrent-files!!!\"";
            this._cbIsSaveTorrentFile.UseVisualStyleBackColor = true;
            this._cbIsSaveTorrentFile.CheckedChanged += new System.EventHandler(this._Focus_Enter);
            // 
            // _cbIsSaveWebPage
            // 
            this._cbIsSaveWebPage.AutoSize = true;
            this._cbIsSaveWebPage.Location = new System.Drawing.Point(9, 179);
            this._cbIsSaveWebPage.Name = "_cbIsSaveWebPage";
            this._cbIsSaveWebPage.Size = new System.Drawing.Size(354, 17);
            this._cbIsSaveWebPage.TabIndex = 12;
            this._cbIsSaveWebPage.Text = "Сохранять web-страницы раздачи в подкаталог \"!!!Web-pages!!!\"";
            this._cbIsSaveWebPage.UseVisualStyleBackColor = true;
            this._cbIsSaveWebPage.CheckedChanged += new System.EventHandler(this._Focus_Enter);
            // 
            // _CategoriesCbTorrentClient
            // 
            this._CategoriesCbTorrentClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CategoriesCbTorrentClient.FormattingEnabled = true;
            this._CategoriesCbTorrentClient.Location = new System.Drawing.Point(336, 59);
            this._CategoriesCbTorrentClient.Name = "_CategoriesCbTorrentClient";
            this._CategoriesCbTorrentClient.Size = new System.Drawing.Size(436, 21);
            this._CategoriesCbTorrentClient.TabIndex = 11;
            this._CategoriesCbTorrentClient.SelectionChangeCommitted += new System.EventHandler(this._Focus_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Торрент-клиент, куда требуется добавлять раздачи:";
            // 
            // _CategoriesTbFolderDownloads
            // 
            this._CategoriesTbFolderDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._CategoriesTbFolderDownloads.Location = new System.Drawing.Point(9, 103);
            this._CategoriesTbFolderDownloads.Name = "_CategoriesTbFolderDownloads";
            this._CategoriesTbFolderDownloads.Size = new System.Drawing.Size(733, 20);
            this._CategoriesTbFolderDownloads.TabIndex = 5;
            this._CategoriesTbFolderDownloads.Enter += new System.EventHandler(this._Focus_Enter);
            this._CategoriesTbFolderDownloads.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // _cbSubFolder
            // 
            this._cbSubFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSubFolder.FormattingEnabled = true;
            this._cbSubFolder.Items.AddRange(new object[] {
            "Не нужен",
            "С ID топика",
            "Запрашивать"});
            this._cbSubFolder.Location = new System.Drawing.Point(336, 129);
            this._cbSubFolder.Name = "_cbSubFolder";
            this._cbSubFolder.Size = new System.Drawing.Size(270, 21);
            this._cbSubFolder.TabIndex = 9;
            this._cbSubFolder.SelectionChangeCommitted += new System.EventHandler(this._Focus_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(261, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Создавать подкаталог для добавляемой раздачи:";
            // 
            // _CategoriesBtSelectFolder
            // 
            this._CategoriesBtSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CategoriesBtSelectFolder.Location = new System.Drawing.Point(742, 102);
            this._CategoriesBtSelectFolder.Name = "_CategoriesBtSelectFolder";
            this._CategoriesBtSelectFolder.Size = new System.Drawing.Size(30, 22);
            this._CategoriesBtSelectFolder.TabIndex = 7;
            this._CategoriesBtSelectFolder.Text = "...";
            this._CategoriesBtSelectFolder.UseVisualStyleBackColor = true;
            this._CategoriesBtSelectFolder.Click += new System.EventHandler(this.ClickButtons);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(298, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Помещать новые загрузки этого раздела/подраздела в:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(359, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Остановка происходит при кол-ве сидов больше этого на 2 и больше";
            // 
            // _CategoriesCbStartCountSeeders
            // 
            this._CategoriesCbStartCountSeeders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._CategoriesCbStartCountSeeders.FormattingEnabled = true;
            this._CategoriesCbStartCountSeeders.Items.AddRange(new object[] {
            "-",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this._CategoriesCbStartCountSeeders.Location = new System.Drawing.Point(336, 19);
            this._CategoriesCbStartCountSeeders.Name = "_CategoriesCbStartCountSeeders";
            this._CategoriesCbStartCountSeeders.Size = new System.Drawing.Size(61, 21);
            this._CategoriesCbStartCountSeeders.TabIndex = 1;
            this._CategoriesCbStartCountSeeders.SelectionChangeCommitted += new System.EventHandler(this._Focus_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Запускать раздачу, если сидов не больше:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this._CategoriesTbFullName);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this._CategoriesTbCategoryID);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(778, 113);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Данные о выбраном разделе";
            // 
            // _CategoriesTbFullName
            // 
            this._CategoriesTbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._CategoriesTbFullName.Location = new System.Drawing.Point(6, 58);
            this._CategoriesTbFullName.Multiline = true;
            this._CategoriesTbFullName.Name = "_CategoriesTbFullName";
            this._CategoriesTbFullName.ReadOnly = true;
            this._CategoriesTbFullName.Size = new System.Drawing.Size(766, 49);
            this._CategoriesTbFullName.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Полный путь к разделу:";
            // 
            // _CategoriesTbCategoryID
            // 
            this._CategoriesTbCategoryID.Location = new System.Drawing.Point(96, 19);
            this._CategoriesTbCategoryID.Name = "_CategoriesTbCategoryID";
            this._CategoriesTbCategoryID.ReadOnly = true;
            this._CategoriesTbCategoryID.Size = new System.Drawing.Size(100, 20);
            this._CategoriesTbCategoryID.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "№ подраздела:";
            // 
            // _btCategoryRemove
            // 
            this._btCategoryRemove.Location = new System.Drawing.Point(131, 6);
            this._btCategoryRemove.Name = "_btCategoryRemove";
            this._btCategoryRemove.Size = new System.Drawing.Size(117, 23);
            this._btCategoryRemove.TabIndex = 4;
            this._btCategoryRemove.Text = "Удалить";
            this._btCategoryRemove.UseVisualStyleBackColor = true;
            this._btCategoryRemove.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _btCategoryAdd
            // 
            this._btCategoryAdd.Location = new System.Drawing.Point(8, 6);
            this._btCategoryAdd.Name = "_btCategoryAdd";
            this._btCategoryAdd.Size = new System.Drawing.Size(117, 23);
            this._btCategoryAdd.TabIndex = 3;
            this._btCategoryAdd.Text = "Добавить";
            this._btCategoryAdd.UseVisualStyleBackColor = true;
            this._btCategoryAdd.Click += new System.EventHandler(this.ClickButtons);
            // 
            // dgwCategories
            // 
            this.dgwCategories.AllowUserToAddRows = false;
            this.dgwCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCategoryCategoryID,
            this.ColumnCategoryName});
            this.dgwCategories.Location = new System.Drawing.Point(8, 35);
            this.dgwCategories.MultiSelect = false;
            this.dgwCategories.Name = "dgwCategories";
            this.dgwCategories.ReadOnly = true;
            this.dgwCategories.RowHeadersVisible = false;
            this.dgwCategories.Size = new System.Drawing.Size(240, 550);
            this.dgwCategories.TabIndex = 0;
            this.dgwCategories.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // ColumnCategoryCategoryID
            // 
            this.ColumnCategoryCategoryID.DataPropertyName = "CategoryID";
            this.ColumnCategoryCategoryID.HeaderText = "CategoryID";
            this.ColumnCategoryCategoryID.Name = "ColumnCategoryCategoryID";
            this.ColumnCategoryCategoryID.ReadOnly = true;
            this.ColumnCategoryCategoryID.Visible = false;
            // 
            // ColumnCategoryName
            // 
            this.ColumnCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCategoryName.DataPropertyName = "Name";
            this.ColumnCategoryName.HeaderText = "Раздел";
            this.ColumnCategoryName.Name = "ColumnCategoryName";
            this.ColumnCategoryName.ReadOnly = true;
            // 
            // tbpTorrentClients
            // 
            this.tbpTorrentClients.BackColor = System.Drawing.SystemColors.Control;
            this.tbpTorrentClients.Controls.Add(this.groupBox5);
            this.tbpTorrentClients.Location = new System.Drawing.Point(4, 22);
            this.tbpTorrentClients.Name = "tbpTorrentClients";
            this.tbpTorrentClients.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTorrentClients.Size = new System.Drawing.Size(1041, 591);
            this.tbpTorrentClients.TabIndex = 0;
            this.tbpTorrentClients.Text = "Torrent-клиенты";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this._btTorrentClientAdd);
            this.groupBox5.Controls.Add(this._btTorrentClientDelete);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.dgwTorrentClients);
            this.groupBox5.Controls.Add(this._cbTorrentClientType);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this._tbTorrentClientName);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1026, 360);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Torrent-клиенты";
            // 
            // _btTorrentClientAdd
            // 
            this._btTorrentClientAdd.Location = new System.Drawing.Point(6, 19);
            this._btTorrentClientAdd.Name = "_btTorrentClientAdd";
            this._btTorrentClientAdd.Size = new System.Drawing.Size(117, 23);
            this._btTorrentClientAdd.TabIndex = 1;
            this._btTorrentClientAdd.Text = "Добавить";
            this._btTorrentClientAdd.UseVisualStyleBackColor = true;
            this._btTorrentClientAdd.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _btTorrentClientDelete
            // 
            this._btTorrentClientDelete.Location = new System.Drawing.Point(129, 19);
            this._btTorrentClientDelete.Name = "_btTorrentClientDelete";
            this._btTorrentClientDelete.Size = new System.Drawing.Size(117, 23);
            this._btTorrentClientDelete.TabIndex = 2;
            this._btTorrentClientDelete.Text = "Удалить";
            this._btTorrentClientDelete.UseVisualStyleBackColor = true;
            this._btTorrentClientDelete.Click += new System.EventHandler(this.ClickButtons);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._tcrbRemote);
            this.groupBox3.Controls.Add(this._tcrbCurrent);
            this.groupBox3.Controls.Add(this._tbTorrentClientHostIP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this._tbTorrentClientUserPassword);
            this.groupBox3.Controls.Add(this._tbTorrentClientUserName);
            this.groupBox3.Controls.Add(this._tbTorrentClientPort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(255, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 151);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Доступ к torrent-клиенту";
            // 
            // _tcrbRemote
            // 
            this._tcrbRemote.AutoSize = true;
            this._tcrbRemote.Location = new System.Drawing.Point(9, 43);
            this._tcrbRemote.Name = "_tcrbRemote";
            this._tcrbRemote.Size = new System.Drawing.Size(211, 17);
            this._tcrbRemote.TabIndex = 9;
            this._tcrbRemote.Text = "На другом компьютере, его имя/IP: ";
            this._tcrbRemote.UseVisualStyleBackColor = true;
            this._tcrbRemote.CheckedChanged += new System.EventHandler(this._Focus_Enter);
            // 
            // _tcrbCurrent
            // 
            this._tcrbCurrent.AutoSize = true;
            this._tcrbCurrent.Checked = true;
            this._tcrbCurrent.Location = new System.Drawing.Point(9, 20);
            this._tcrbCurrent.Name = "_tcrbCurrent";
            this._tcrbCurrent.Size = new System.Drawing.Size(150, 17);
            this._tcrbCurrent.TabIndex = 8;
            this._tcrbCurrent.TabStop = true;
            this._tcrbCurrent.Text = "На этом же компьютере";
            this._tcrbCurrent.UseVisualStyleBackColor = true;
            this._tcrbCurrent.CheckedChanged += new System.EventHandler(this._Focus_Enter);
            // 
            // _tbTorrentClientHostIP
            // 
            this._tbTorrentClientHostIP.Location = new System.Drawing.Point(226, 42);
            this._tbTorrentClientHostIP.Name = "_tbTorrentClientHostIP";
            this._tbTorrentClientHostIP.Size = new System.Drawing.Size(150, 20);
            this._tbTorrentClientHostIP.TabIndex = 6;
            this._tbTorrentClientHostIP.Enter += new System.EventHandler(this._Focus_Enter);
            this._tbTorrentClientHostIP.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пароль пользователя torrent-клиента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Имя пользователя torrent-клиента:";
            // 
            // _tbTorrentClientUserPassword
            // 
            this._tbTorrentClientUserPassword.Location = new System.Drawing.Point(226, 120);
            this._tbTorrentClientUserPassword.Name = "_tbTorrentClientUserPassword";
            this._tbTorrentClientUserPassword.PasswordChar = '*';
            this._tbTorrentClientUserPassword.Size = new System.Drawing.Size(150, 20);
            this._tbTorrentClientUserPassword.TabIndex = 3;
            this._tbTorrentClientUserPassword.Enter += new System.EventHandler(this._Focus_Enter);
            this._tbTorrentClientUserPassword.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // _tbTorrentClientUserName
            // 
            this._tbTorrentClientUserName.Location = new System.Drawing.Point(226, 94);
            this._tbTorrentClientUserName.Name = "_tbTorrentClientUserName";
            this._tbTorrentClientUserName.Size = new System.Drawing.Size(150, 20);
            this._tbTorrentClientUserName.TabIndex = 2;
            this._tbTorrentClientUserName.Enter += new System.EventHandler(this._Focus_Enter);
            this._tbTorrentClientUserName.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // _tbTorrentClientPort
            // 
            this._tbTorrentClientPort.Location = new System.Drawing.Point(226, 68);
            this._tbTorrentClientPort.Name = "_tbTorrentClientPort";
            this._tbTorrentClientPort.Size = new System.Drawing.Size(150, 20);
            this._tbTorrentClientPort.TabIndex = 1;
            this._tbTorrentClientPort.Enter += new System.EventHandler(this._Focus_Enter);
            this._tbTorrentClientPort.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Порт Web/API-интерфейса:";
            // 
            // dgwTorrentClients
            // 
            this.dgwTorrentClients.AllowUserToAddRows = false;
            this.dgwTorrentClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgwTorrentClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTorrentClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.FolderName});
            this.dgwTorrentClients.Location = new System.Drawing.Point(6, 48);
            this.dgwTorrentClients.MultiSelect = false;
            this.dgwTorrentClients.Name = "dgwTorrentClients";
            this.dgwTorrentClients.RowHeadersVisible = false;
            this.dgwTorrentClients.Size = new System.Drawing.Size(240, 306);
            this.dgwTorrentClients.TabIndex = 0;
            this.dgwTorrentClients.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Visible = false;
            // 
            // FolderName
            // 
            this.FolderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FolderName.DataPropertyName = "Name";
            this.FolderName.HeaderText = "Настройки";
            this.FolderName.Name = "FolderName";
            this.FolderName.ReadOnly = true;
            // 
            // _cbTorrentClientType
            // 
            this._cbTorrentClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTorrentClientType.FormattingEnabled = true;
            this._cbTorrentClientType.Items.AddRange(new object[] {
            "uTorrent",
            "Transmission",
            "Vuze (Vuze Web Remote)"});
            this._cbTorrentClientType.Location = new System.Drawing.Point(481, 71);
            this._cbTorrentClientType.Name = "_cbTorrentClientType";
            this._cbTorrentClientType.Size = new System.Drawing.Size(121, 21);
            this._cbTorrentClientType.TabIndex = 6;
            this._cbTorrentClientType.Enter += new System.EventHandler(this._Focus_Enter);
            this._cbTorrentClientType.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип torrent-клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название группы настроек torrent-клиента:";
            // 
            // _tbTorrentClientName
            // 
            this._tbTorrentClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbTorrentClientName.Location = new System.Drawing.Point(481, 45);
            this._tbTorrentClientName.Name = "_tbTorrentClientName";
            this._tbTorrentClientName.Size = new System.Drawing.Size(539, 20);
            this._tbTorrentClientName.TabIndex = 4;
            this._tbTorrentClientName.Enter += new System.EventHandler(this._Focus_Enter);
            this._tbTorrentClientName.Leave += new System.EventHandler(this._Focus_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbpTorrentClients);
            this.tabControl1.Controls.Add(this._tpCategories);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this._tpAllCategories);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 591);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Основные настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.label37);
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this._appReportBottom);
            this.groupBox8.Controls.Add(this.label31);
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this._appReportTop2);
            this.groupBox8.Controls.Add(this._appReportTop1);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this._appReportLine);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this._appCountSeedersReport);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Location = new System.Drawing.Point(381, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(653, 485);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Настройки отчетов";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label39.Location = new System.Drawing.Point(229, 366);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(177, 13);
            this.label39.TabIndex = 31;
            this.label39.Text = "%%ReportLines%% - Строки отчета";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label38.Location = new System.Drawing.Point(229, 353);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(228, 13);
            this.label38.TabIndex = 30;
            this.label38.Text = "%%NumberTopicsLast%% - Последний номер";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label37.Location = new System.Drawing.Point(229, 339);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(228, 13);
            this.label37.TabIndex = 29;
            this.label37.Text = "%%NumberTopicsFirst%% - Начальный номер";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label36.Location = new System.Drawing.Point(229, 326);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(197, 13);
            this.label36.TabIndex = 28;
            this.label36.Text = "%%Top1%% - Вписать первый шаблон";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label35.Location = new System.Drawing.Point(6, 352);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(196, 13);
            this.label35.TabIndex = 27;
            this.label35.Text = "%%SizeTopics%% - Размер хранимого";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label34.Location = new System.Drawing.Point(6, 339);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(180, 13);
            this.label34.TabIndex = 26;
            this.label34.Text = "%%CountTopics%% - Кол-во раздач";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label33.Location = new System.Drawing.Point(6, 326);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(196, 13);
            this.label33.TabIndex = 25;
            this.label33.Text = "%%CreateDate%% - Дата составления";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 382);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(94, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "Шаблон подвала:";
            // 
            // _appReportBottom
            // 
            this._appReportBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appReportBottom.Location = new System.Drawing.Point(6, 398);
            this._appReportBottom.Multiline = true;
            this._appReportBottom.Name = "_appReportBottom";
            this._appReportBottom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._appReportBottom.Size = new System.Drawing.Size(638, 79);
            this._appReportBottom.TabIndex = 23;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 228);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(162, 13);
            this.label31.TabIndex = 22;
            this.label31.Text = "Шаблон общей шапки отчетов:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 127);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(164, 13);
            this.label30.TabIndex = 21;
            this.label30.Text = "Шаблон шапки первого отчета:";
            // 
            // _appReportTop2
            // 
            this._appReportTop2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appReportTop2.Location = new System.Drawing.Point(9, 244);
            this._appReportTop2.Multiline = true;
            this._appReportTop2.Name = "_appReportTop2";
            this._appReportTop2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._appReportTop2.Size = new System.Drawing.Size(638, 79);
            this._appReportTop2.TabIndex = 20;
            // 
            // _appReportTop1
            // 
            this._appReportTop1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appReportTop1.Location = new System.Drawing.Point(9, 143);
            this._appReportTop1.Multiline = true;
            this._appReportTop1.Name = "_appReportTop1";
            this._appReportTop1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._appReportTop1.Size = new System.Drawing.Size(638, 79);
            this._appReportTop1.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label29.Location = new System.Drawing.Point(390, 110);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(161, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "%%Date%% - дата регистрации";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label28.Location = new System.Drawing.Point(390, 98);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(181, 13);
            this.label28.TabIndex = 17;
            this.label28.Text = "%%CountSeeders%% - кол-во сидов";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label27.Location = new System.Drawing.Point(229, 98);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(151, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "%%Size%% - Размер раздачи";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label26.Location = new System.Drawing.Point(229, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(155, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "%%Status%% - статус раздачи";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label25.Location = new System.Drawing.Point(6, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(194, 13);
            this.label25.TabIndex = 14;
            this.label25.Text = "%%Name%% - наименование раздачи";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label24.Location = new System.Drawing.Point(6, 97);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "%%ID%% - идентификатор раздачи";
            // 
            // _appReportLine
            // 
            this._appReportLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appReportLine.Location = new System.Drawing.Point(9, 75);
            this._appReportLine.Name = "_appReportLine";
            this._appReportLine.Size = new System.Drawing.Size(638, 20);
            this._appReportLine.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Шаблон строки отчета:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "В отчете о сидируемых раздачах отображаются раздачи с кол-вом сидов не более:";
            // 
            // _appCountSeedersReport
            // 
            this._appCountSeedersReport.Location = new System.Drawing.Point(443, 19);
            this._appCountSeedersReport.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._appCountSeedersReport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this._appCountSeedersReport.Name = "_appCountSeedersReport";
            this._appCountSeedersReport.Size = new System.Drawing.Size(63, 20);
            this._appCountSeedersReport.TabIndex = 9;
            this._appCountSeedersReport.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(6, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(560, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Если требуется чтобы в отчет попадали все раздачи указанной категории, требуется" +
    " указать значение \"-1\"";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._dbLoadInMemoryCheckbox);
            this.groupBox4.Controls.Add(this._appIsNotSaveStatistics);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this._appLogLevel);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this._appSelectLessOrEqual);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this._appIsUpdateStatistics);
            this.groupBox4.Controls.Add(this._appPeriodRunAndStopTorrents);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(8, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 415);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройки программы";
            // 
            // _dbLoadInMemoryCheckbox
            // 
            this._dbLoadInMemoryCheckbox.Location = new System.Drawing.Point(6, 244);
            this._dbLoadInMemoryCheckbox.Name = "_dbLoadInMemoryCheckbox";
            this._dbLoadInMemoryCheckbox.Size = new System.Drawing.Size(219, 17);
            this._dbLoadInMemoryCheckbox.TabIndex = 17;
            this._dbLoadInMemoryCheckbox.Text = "Выгружать БД в оперативную память";
            this._dbLoadInMemoryCheckbox.UseVisualStyleBackColor = true;
            this._dbLoadInMemoryCheckbox.Click += new System.EventHandler(this.ClickButtons);
            // 
            // _appIsNotSaveStatistics
            // 
            this._appIsNotSaveStatistics.AutoSize = true;
            this._appIsNotSaveStatistics.Location = new System.Drawing.Point(6, 46);
            this._appIsNotSaveStatistics.Name = "_appIsNotSaveStatistics";
            this._appIsNotSaveStatistics.Size = new System.Drawing.Size(296, 17);
            this._appIsNotSaveStatistics.TabIndex = 16;
            this._appIsNotSaveStatistics.Text = "Не сохранять статистику о кол-ве сидов на раздачах";
            this._appIsNotSaveStatistics.UseVisualStyleBackColor = true;
            this._appIsNotSaveStatistics.Click += new System.EventHandler(this.SelectionChanged);
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label23.Location = new System.Drawing.Point(6, 198);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(355, 42);
            this.label23.TabIndex = 15;
            this.label23.Text = "Отвечает за подробность ведения текстового лога. 0 - ошибки/предупреждения, 1 - +" +
    "информационные сообщения, 2 - + отладочные сообщения, 3 - + шаги выполнения прог" +
    "раммы";
            // 
            // _appLogLevel
            // 
            this._appLogLevel.Location = new System.Drawing.Point(298, 175);
            this._appLogLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._appLogLevel.Name = "_appLogLevel";
            this._appLogLevel.Size = new System.Drawing.Size(63, 20);
            this._appLogLevel.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(231, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Уровень ведения логов (значение от 0 до 3)";
            // 
            // label20
            // 
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(6, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(355, 30);
            this.label20.TabIndex = 12;
            this.label20.Text = "Если флаг не установлен, то на главной форме будет использоваться строгое соответ" +
    "ствие указаному значению";
            // 
            // _appSelectLessOrEqual
            // 
            this._appSelectLessOrEqual.AutoSize = true;
            this._appSelectLessOrEqual.Location = new System.Drawing.Point(6, 122);
            this._appSelectLessOrEqual.Name = "_appSelectLessOrEqual";
            this._appSelectLessOrEqual.Size = new System.Drawing.Size(278, 17);
            this._appSelectLessOrEqual.TabIndex = 11;
            this._appSelectLessOrEqual.Text = "Использовать отбор как <= указанного значения";
            this._appSelectLessOrEqual.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(6, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 30);
            this.label12.TabIndex = 7;
            this.label12.Text = "Операция по обновлению статистики ресурсоемкая при наличии большого кол-ва раздел" +
    "ов и продолжается значительное время";
            // 
            // _appIsUpdateStatistics
            // 
            this._appIsUpdateStatistics.AutoSize = true;
            this._appIsUpdateStatistics.Location = new System.Drawing.Point(6, 69);
            this._appIsUpdateStatistics.Name = "_appIsUpdateStatistics";
            this._appIsUpdateStatistics.Size = new System.Drawing.Size(301, 17);
            this._appIsUpdateStatistics.TabIndex = 6;
            this._appIsUpdateStatistics.Text = "Обновлять статистику при запуске/остановке раздач";
            this._appIsUpdateStatistics.UseVisualStyleBackColor = true;
            // 
            // _appPeriodRunAndStopTorrents
            // 
            this._appPeriodRunAndStopTorrents.Location = new System.Drawing.Point(259, 20);
            this._appPeriodRunAndStopTorrents.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this._appPeriodRunAndStopTorrents.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._appPeriodRunAndStopTorrents.Name = "_appPeriodRunAndStopTorrents";
            this._appPeriodRunAndStopTorrents.Size = new System.Drawing.Size(102, 20);
            this._appPeriodRunAndStopTorrents.TabIndex = 5;
            this._appPeriodRunAndStopTorrents.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Период цикла запуска/остановки раздач, мин.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._appCountDaysKeepHistory);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this._appIsAvgCountSeeders);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отбор раздач";
            // 
            // _appCountDaysKeepHistory
            // 
            this._appCountDaysKeepHistory.Location = new System.Drawing.Point(218, 42);
            this._appCountDaysKeepHistory.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._appCountDaysKeepHistory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._appCountDaysKeepHistory.Name = "_appCountDaysKeepHistory";
            this._appCountDaysKeepHistory.Size = new System.Drawing.Size(102, 20);
            this._appCountDaysKeepHistory.TabIndex = 6;
            this._appCountDaysKeepHistory.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Хранить историю о кол-ве сидов, дней:";
            // 
            // _appIsAvgCountSeeders
            // 
            this._appIsAvgCountSeeders.AutoSize = true;
            this._appIsAvgCountSeeders.Location = new System.Drawing.Point(6, 19);
            this._appIsAvgCountSeeders.Name = "_appIsAvgCountSeeders";
            this._appIsAvgCountSeeders.Size = new System.Drawing.Size(302, 17);
            this._appIsAvgCountSeeders.TabIndex = 0;
            this._appIsAvgCountSeeders.Text = "Использовать отбор и сортировку по ср. кол-ву сидов";
            this._appIsAvgCountSeeders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._appKeeperPass);
            this.groupBox1.Controls.Add(this._appKeeperName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация на сайте:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Пароль пользователя сайта:";
            // 
            // _appKeeperPass
            // 
            this._appKeeperPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appKeeperPass.Location = new System.Drawing.Point(166, 45);
            this._appKeeperPass.Name = "_appKeeperPass";
            this._appKeeperPass.PasswordChar = '*';
            this._appKeeperPass.Size = new System.Drawing.Size(195, 20);
            this._appKeeperPass.TabIndex = 2;
            // 
            // _appKeeperName
            // 
            this._appKeeperName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._appKeeperName.Location = new System.Drawing.Point(166, 19);
            this._appKeeperName.Name = "_appKeeperName";
            this._appKeeperName.Size = new System.Drawing.Size(195, 20);
            this._appKeeperName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Логин пользователя сайта:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.forumPages1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 591);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Отправка отчетов на форум";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // forumPages1
            // 
            this.forumPages1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forumPages1.Location = new System.Drawing.Point(0, 0);
            this.forumPages1.Name = "forumPages1";
            this.forumPages1.Size = new System.Drawing.Size(1041, 591);
            this.forumPages1.TabIndex = 0;
            // 
            // _tpAllCategories
            // 
            this._tpAllCategories.Controls.Add(this.panel2);
            this._tpAllCategories.Location = new System.Drawing.Point(4, 22);
            this._tpAllCategories.Name = "_tpAllCategories";
            this._tpAllCategories.Padding = new System.Windows.Forms.Padding(3);
            this._tpAllCategories.Size = new System.Drawing.Size(1041, 591);
            this._tpAllCategories.TabIndex = 7;
            this._tpAllCategories.Text = "Все категории";
            this._tpAllCategories.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 537);
            this.panel2.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 649);
            this.Controls.Add(this._btCancel);
            this.Controls.Add(this._btCheck);
            this.Controls.Add(this._btSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this._tpCategories.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).EndInit();
            this.tbpTorrentClients.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTorrentClients)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appCountSeedersReport)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appLogLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._appPeriodRunAndStopTorrents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._appCountDaysKeepHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this._tpAllCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}