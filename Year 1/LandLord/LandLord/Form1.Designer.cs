namespace LandLord
{
    partial class Form1
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
			this.QuitGameBtn = new System.Windows.Forms.Button();
			this.Moneylabel = new System.Windows.Forms.Label();
			this.MoneyDisplaylabel = new System.Windows.Forms.Label();
			this.Timeflow = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadGameItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveGameItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QuitGameItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadGameBtn = new System.Windows.Forms.Button();
			this.NewGameBtn = new System.Windows.Forms.Button();
			this.StartBtn = new System.Windows.Forms.Button();
			this.AvQGPanel = new System.Windows.Forms.Panel();
			this.AvQGTB = new System.Windows.Forms.TextBox();
			this.QGCancelBtn = new System.Windows.Forms.Button();
			this.QGLeaveBtn = new System.Windows.Forms.Button();
			this.AvNGPanel = new System.Windows.Forms.Panel();
			this.AvNGTB = new System.Windows.Forms.TextBox();
			this.NGCancelBtn = new System.Windows.Forms.Button();
			this.NGLeaveBtn = new System.Windows.Forms.Button();
			this.DecisionBuyPanel = new System.Windows.Forms.Panel();
			this.OwnerLbl2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BuildingBuyValueLbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DecisionBuyBox = new System.Windows.Forms.TextBox();
			this.BuyBtn = new System.Windows.Forms.Button();
			this.StartMenu = new System.Windows.Forms.Panel();
			this.ExitAppBtn = new System.Windows.Forms.Button();
			this.NewGameMenu = new System.Windows.Forms.Panel();
			this.BotNumberComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.PNameTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.PlayerColorComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.InitialMoneyComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.GameMenu = new System.Windows.Forms.Panel();
			this.ImpositsPanel = new System.Windows.Forms.Panel();
			this.ImpositstextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.RenttextBox = new System.Windows.Forms.TextBox();
			this.Flowinglbl = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SearchPlayerBtn = new System.Windows.Forms.Button();
			this.CentralBoard = new System.Windows.Forms.ListView();
			this.PlayersListBoard = new System.Windows.Forms.ComboBox();
			this.DecisionSellPanel = new System.Windows.Forms.Panel();
			this.OwnerLbl1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BuildingActualPriceLbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BuildingSellValueLbl = new System.Windows.Forms.Label();
			this.Sell = new System.Windows.Forms.Label();
			this.ItemBoughtBox = new System.Windows.Forms.TextBox();
			this.SellBtn = new System.Windows.Forms.Button();
			this.DecisionSuccessSoldPanel = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.DecisionSuccessBoughtPanel = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.DecisionNoMoneyPanel = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.WONpanel = new System.Windows.Forms.Panel();
			this.textBox50 = new System.Windows.Forms.TextBox();
			this.textBoxYW = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.menuStrip1.SuspendLayout();
			this.AvQGPanel.SuspendLayout();
			this.AvNGPanel.SuspendLayout();
			this.DecisionBuyPanel.SuspendLayout();
			this.StartMenu.SuspendLayout();
			this.NewGameMenu.SuspendLayout();
			this.GameMenu.SuspendLayout();
			this.ImpositsPanel.SuspendLayout();
			this.DecisionSellPanel.SuspendLayout();
			this.DecisionSuccessSoldPanel.SuspendLayout();
			this.DecisionSuccessBoughtPanel.SuspendLayout();
			this.DecisionNoMoneyPanel.SuspendLayout();
			this.WONpanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// QuitGameBtn
			// 
			this.QuitGameBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.QuitGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.QuitGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuitGameBtn.ForeColor = System.Drawing.Color.Crimson;
			this.QuitGameBtn.Location = new System.Drawing.Point(364, 553);
			this.QuitGameBtn.Name = "QuitGameBtn";
			this.QuitGameBtn.Size = new System.Drawing.Size(75, 23);
			this.QuitGameBtn.TabIndex = 2;
			this.QuitGameBtn.Text = "Quit Game";
			this.QuitGameBtn.UseVisualStyleBackColor = false;
			this.QuitGameBtn.Visible = false;
			this.QuitGameBtn.Click += new System.EventHandler(this.QuitGameBtn_Click);
			// 
			// Moneylabel
			// 
			this.Moneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Moneylabel.Location = new System.Drawing.Point(61, 1);
			this.Moneylabel.Name = "Moneylabel";
			this.Moneylabel.Size = new System.Drawing.Size(24, 17);
			this.Moneylabel.TabIndex = 4;
			this.Moneylabel.Text = "$:";
			// 
			// MoneyDisplaylabel
			// 
			this.MoneyDisplaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MoneyDisplaylabel.Location = new System.Drawing.Point(91, 1);
			this.MoneyDisplaylabel.Name = "MoneyDisplaylabel";
			this.MoneyDisplaylabel.Size = new System.Drawing.Size(100, 23);
			this.MoneyDisplaylabel.TabIndex = 3;
			this.MoneyDisplaylabel.Text = "Money";
			// 
			// Timeflow
			// 
			this.Timeflow.Interval = 1000;
			this.Timeflow.Tick += new System.EventHandler(this.Timeflow_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1900, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// selectToolStripMenuItem
			// 
			this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameItem,
            this.loadGameItem,
            this.saveGameItem,
            this.QuitGameItem});
			this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
			this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.selectToolStripMenuItem.Text = "Select";
			// 
			// newGameItem
			// 
			this.newGameItem.Name = "newGameItem";
			this.newGameItem.Size = new System.Drawing.Size(134, 22);
			this.newGameItem.Text = "New Game";
			this.newGameItem.Click += new System.EventHandler(this.newGamItem_Click);
			// 
			// loadGameItem
			// 
			this.loadGameItem.Name = "loadGameItem";
			this.loadGameItem.Size = new System.Drawing.Size(134, 22);
			this.loadGameItem.Text = "Load Game";
			// 
			// saveGameItem
			// 
			this.saveGameItem.Name = "saveGameItem";
			this.saveGameItem.Size = new System.Drawing.Size(134, 22);
			this.saveGameItem.Text = "Save Game";
			// 
			// QuitGameItem
			// 
			this.QuitGameItem.Name = "QuitGameItem";
			this.QuitGameItem.Size = new System.Drawing.Size(134, 22);
			this.QuitGameItem.Text = "Quit Game";
			this.QuitGameItem.Click += new System.EventHandler(this.QuitGameItem_Click);
			// 
			// LoadGameBtn
			// 
			this.LoadGameBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.LoadGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LoadGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoadGameBtn.ForeColor = System.Drawing.Color.Crimson;
			this.LoadGameBtn.Location = new System.Drawing.Point(14, 252);
			this.LoadGameBtn.Name = "LoadGameBtn";
			this.LoadGameBtn.Size = new System.Drawing.Size(75, 23);
			this.LoadGameBtn.TabIndex = 10;
			this.LoadGameBtn.Text = "Load Game";
			this.LoadGameBtn.UseVisualStyleBackColor = false;
			// 
			// NewGameBtn
			// 
			this.NewGameBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.NewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewGameBtn.ForeColor = System.Drawing.Color.Crimson;
			this.NewGameBtn.Location = new System.Drawing.Point(14, 114);
			this.NewGameBtn.Name = "NewGameBtn";
			this.NewGameBtn.Size = new System.Drawing.Size(75, 23);
			this.NewGameBtn.TabIndex = 9;
			this.NewGameBtn.Text = "New Game";
			this.NewGameBtn.UseVisualStyleBackColor = false;
			this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
			// 
			// StartBtn
			// 
			this.StartBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartBtn.ForeColor = System.Drawing.Color.Crimson;
			this.StartBtn.Location = new System.Drawing.Point(46, 158);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(75, 23);
			this.StartBtn.TabIndex = 3;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = false;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// AvQGPanel
			// 
			this.AvQGPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AvQGPanel.BackColor = System.Drawing.Color.Red;
			this.AvQGPanel.Controls.Add(this.AvQGTB);
			this.AvQGPanel.Controls.Add(this.QGCancelBtn);
			this.AvQGPanel.Controls.Add(this.QGLeaveBtn);
			this.AvQGPanel.Location = new System.Drawing.Point(581, 190);
			this.AvQGPanel.Name = "AvQGPanel";
			this.AvQGPanel.Size = new System.Drawing.Size(300, 100);
			this.AvQGPanel.TabIndex = 10;
			this.AvQGPanel.Visible = false;
			// 
			// AvQGTB
			// 
			this.AvQGTB.BackColor = System.Drawing.Color.Red;
			this.AvQGTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AvQGTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AvQGTB.ForeColor = System.Drawing.SystemColors.Window;
			this.AvQGTB.Location = new System.Drawing.Point(22, 32);
			this.AvQGTB.Name = "AvQGTB";
			this.AvQGTB.Size = new System.Drawing.Size(250, 13);
			this.AvQGTB.TabIndex = 5;
			this.AvQGTB.Text = "ARE YOU SURE YOU WANT TO QUIT?";
			this.AvQGTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// QGCancelBtn
			// 
			this.QGCancelBtn.BackColor = System.Drawing.Color.Gold;
			this.QGCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.QGCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QGCancelBtn.ForeColor = System.Drawing.Color.Crimson;
			this.QGCancelBtn.Location = new System.Drawing.Point(197, 74);
			this.QGCancelBtn.Name = "QGCancelBtn";
			this.QGCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.QGCancelBtn.TabIndex = 4;
			this.QGCancelBtn.Text = "Cancel";
			this.QGCancelBtn.UseVisualStyleBackColor = false;
			this.QGCancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// QGLeaveBtn
			// 
			this.QGLeaveBtn.BackColor = System.Drawing.Color.Gold;
			this.QGLeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.QGLeaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QGLeaveBtn.ForeColor = System.Drawing.Color.Crimson;
			this.QGLeaveBtn.Location = new System.Drawing.Point(22, 74);
			this.QGLeaveBtn.Name = "QGLeaveBtn";
			this.QGLeaveBtn.Size = new System.Drawing.Size(75, 23);
			this.QGLeaveBtn.TabIndex = 3;
			this.QGLeaveBtn.Text = "Leave";
			this.QGLeaveBtn.UseVisualStyleBackColor = false;
			this.QGLeaveBtn.Click += new System.EventHandler(this.QGLeaveBtn_Click);
			// 
			// AvNGPanel
			// 
			this.AvNGPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AvNGPanel.BackColor = System.Drawing.Color.Red;
			this.AvNGPanel.Controls.Add(this.AvNGTB);
			this.AvNGPanel.Controls.Add(this.NGCancelBtn);
			this.AvNGPanel.Controls.Add(this.NGLeaveBtn);
			this.AvNGPanel.Location = new System.Drawing.Point(508, 293);
			this.AvNGPanel.Name = "AvNGPanel";
			this.AvNGPanel.Size = new System.Drawing.Size(357, 117);
			this.AvNGPanel.TabIndex = 11;
			this.AvNGPanel.Visible = false;
			// 
			// AvNGTB
			// 
			this.AvNGTB.BackColor = System.Drawing.Color.Red;
			this.AvNGTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AvNGTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AvNGTB.ForeColor = System.Drawing.SystemColors.Window;
			this.AvNGTB.Location = new System.Drawing.Point(22, 32);
			this.AvNGTB.Name = "AvNGTB";
			this.AvNGTB.Size = new System.Drawing.Size(322, 13);
			this.AvNGTB.TabIndex = 5;
			this.AvNGTB.Text = "ARE YOU SURE YOU WANT TO START A NEW GAME?";
			this.AvNGTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NGCancelBtn
			// 
			this.NGCancelBtn.BackColor = System.Drawing.Color.Gold;
			this.NGCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NGCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NGCancelBtn.ForeColor = System.Drawing.Color.Crimson;
			this.NGCancelBtn.Location = new System.Drawing.Point(269, 74);
			this.NGCancelBtn.Name = "NGCancelBtn";
			this.NGCancelBtn.Size = new System.Drawing.Size(75, 23);
			this.NGCancelBtn.TabIndex = 4;
			this.NGCancelBtn.Text = "Cancel";
			this.NGCancelBtn.UseVisualStyleBackColor = false;
			this.NGCancelBtn.Click += new System.EventHandler(this.NGCancelBtn_Click);
			// 
			// NGLeaveBtn
			// 
			this.NGLeaveBtn.BackColor = System.Drawing.Color.Gold;
			this.NGLeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NGLeaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NGLeaveBtn.ForeColor = System.Drawing.Color.Crimson;
			this.NGLeaveBtn.Location = new System.Drawing.Point(22, 74);
			this.NGLeaveBtn.Name = "NGLeaveBtn";
			this.NGLeaveBtn.Size = new System.Drawing.Size(75, 23);
			this.NGLeaveBtn.TabIndex = 3;
			this.NGLeaveBtn.Text = "New Game";
			this.NGLeaveBtn.UseVisualStyleBackColor = false;
			this.NGLeaveBtn.Click += new System.EventHandler(this.NGLeaveBtn_Click);
			// 
			// DecisionBuyPanel
			// 
			this.DecisionBuyPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.DecisionBuyPanel.Controls.Add(this.OwnerLbl2);
			this.DecisionBuyPanel.Controls.Add(this.label7);
			this.DecisionBuyPanel.Controls.Add(this.BuildingBuyValueLbl);
			this.DecisionBuyPanel.Controls.Add(this.label1);
			this.DecisionBuyPanel.Controls.Add(this.DecisionBuyBox);
			this.DecisionBuyPanel.Controls.Add(this.BuyBtn);
			this.DecisionBuyPanel.Location = new System.Drawing.Point(160, 205);
			this.DecisionBuyPanel.Name = "DecisionBuyPanel";
			this.DecisionBuyPanel.Size = new System.Drawing.Size(281, 85);
			this.DecisionBuyPanel.TabIndex = 80;
			this.DecisionBuyPanel.Visible = false;
			// 
			// OwnerLbl2
			// 
			this.OwnerLbl2.AutoSize = true;
			this.OwnerLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OwnerLbl2.Location = new System.Drawing.Point(135, 3);
			this.OwnerLbl2.Name = "OwnerLbl2";
			this.OwnerLbl2.Size = new System.Drawing.Size(63, 16);
			this.OwnerLbl2.TabIndex = 14;
			this.OwnerLbl2.Text = "Nobody";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(74, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 16);
			this.label7.TabIndex = 13;
			this.label7.Text = "Owner:";
			// 
			// BuildingBuyValueLbl
			// 
			this.BuildingBuyValueLbl.AutoSize = true;
			this.BuildingBuyValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildingBuyValueLbl.Location = new System.Drawing.Point(140, 36);
			this.BuildingBuyValueLbl.Name = "BuildingBuyValueLbl";
			this.BuildingBuyValueLbl.Size = new System.Drawing.Size(39, 16);
			this.BuildingBuyValueLbl.TabIndex = 8;
			this.BuildingBuyValueLbl.Text = "Cost";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(74, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cost:";
			// 
			// DecisionBuyBox
			// 
			this.DecisionBuyBox.BackColor = System.Drawing.Color.YellowGreen;
			this.DecisionBuyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DecisionBuyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DecisionBuyBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.DecisionBuyBox.Location = new System.Drawing.Point(22, 22);
			this.DecisionBuyBox.Name = "DecisionBuyBox";
			this.DecisionBuyBox.Size = new System.Drawing.Size(243, 13);
			this.DecisionBuyBox.TabIndex = 6;
			this.DecisionBuyBox.Text = "Would you like to buy this building?";
			this.DecisionBuyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BuyBtn
			// 
			this.BuyBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuyBtn.ForeColor = System.Drawing.Color.Crimson;
			this.BuyBtn.Location = new System.Drawing.Point(94, 52);
			this.BuyBtn.Name = "BuyBtn";
			this.BuyBtn.Size = new System.Drawing.Size(75, 25);
			this.BuyBtn.TabIndex = 4;
			this.BuyBtn.Text = "Buy";
			this.BuyBtn.UseVisualStyleBackColor = false;
			this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
			// 
			// StartMenu
			// 
			this.StartMenu.BackColor = System.Drawing.SystemColors.ControlDark;
			this.StartMenu.Controls.Add(this.ExitAppBtn);
			this.StartMenu.Controls.Add(this.LoadGameBtn);
			this.StartMenu.Controls.Add(this.NewGameBtn);
			this.StartMenu.Location = new System.Drawing.Point(900, 0);
			this.StartMenu.Name = "StartMenu";
			this.StartMenu.Size = new System.Drawing.Size(108, 1040);
			this.StartMenu.TabIndex = 80;
			// 
			// ExitAppBtn
			// 
			this.ExitAppBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.ExitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ExitAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitAppBtn.ForeColor = System.Drawing.Color.Crimson;
			this.ExitAppBtn.Location = new System.Drawing.Point(14, 784);
			this.ExitAppBtn.Name = "ExitAppBtn";
			this.ExitAppBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitAppBtn.TabIndex = 11;
			this.ExitAppBtn.Text = "Exit Game";
			this.ExitAppBtn.UseVisualStyleBackColor = false;
			this.ExitAppBtn.Click += new System.EventHandler(this.ExitAppBtn_Click);
			// 
			// NewGameMenu
			// 
			this.NewGameMenu.BackColor = System.Drawing.SystemColors.MenuBar;
			this.NewGameMenu.Controls.Add(this.BotNumberComboBox);
			this.NewGameMenu.Controls.Add(this.label8);
			this.NewGameMenu.Controls.Add(this.PNameTextBox);
			this.NewGameMenu.Controls.Add(this.label6);
			this.NewGameMenu.Controls.Add(this.PlayerColorComboBox);
			this.NewGameMenu.Controls.Add(this.label4);
			this.NewGameMenu.Controls.Add(this.InitialMoneyComboBox);
			this.NewGameMenu.Controls.Add(this.label3);
			this.NewGameMenu.Controls.Add(this.StartBtn);
			this.NewGameMenu.Location = new System.Drawing.Point(868, 453);
			this.NewGameMenu.Name = "NewGameMenu";
			this.NewGameMenu.Size = new System.Drawing.Size(175, 202);
			this.NewGameMenu.TabIndex = 83;
			this.NewGameMenu.Visible = false;
			// 
			// BotNumberComboBox
			// 
			this.BotNumberComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.BotNumberComboBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.BotNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotNumberComboBox.FormattingEnabled = true;
			this.BotNumberComboBox.Location = new System.Drawing.Point(72, 115);
			this.BotNumberComboBox.Name = "BotNumberComboBox";
			this.BotNumberComboBox.Size = new System.Drawing.Size(100, 21);
			this.BotNumberComboBox.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(2, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Bot Number: ";
			// 
			// PNameTextBox
			// 
			this.PNameTextBox.Location = new System.Drawing.Point(72, 16);
			this.PNameTextBox.Name = "PNameTextBox";
			this.PNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.PNameTextBox.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Player Name:";
			// 
			// PlayerColorComboBox
			// 
			this.PlayerColorComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.PlayerColorComboBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.PlayerColorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayerColorComboBox.FormattingEnabled = true;
			this.PlayerColorComboBox.Location = new System.Drawing.Point(72, 49);
			this.PlayerColorComboBox.Name = "PlayerColorComboBox";
			this.PlayerColorComboBox.Size = new System.Drawing.Size(100, 21);
			this.PlayerColorComboBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(2, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Player Color: ";
			// 
			// InitialMoneyComboBox
			// 
			this.InitialMoneyComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.InitialMoneyComboBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.InitialMoneyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InitialMoneyComboBox.FormattingEnabled = true;
			this.InitialMoneyComboBox.Location = new System.Drawing.Point(72, 81);
			this.InitialMoneyComboBox.Name = "InitialMoneyComboBox";
			this.InitialMoneyComboBox.Size = new System.Drawing.Size(100, 21);
			this.InitialMoneyComboBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Start Money: ";
			// 
			// GameMenu
			// 
			this.GameMenu.Controls.Add(this.ImpositsPanel);
			this.GameMenu.Controls.Add(this.Flowinglbl);
			this.GameMenu.Controls.Add(this.label9);
			this.GameMenu.Controls.Add(this.SearchPlayerBtn);
			this.GameMenu.Controls.Add(this.CentralBoard);
			this.GameMenu.Controls.Add(this.PlayersListBoard);
			this.GameMenu.Controls.Add(this.QuitGameBtn);
			this.GameMenu.Controls.Add(this.MoneyDisplaylabel);
			this.GameMenu.Controls.Add(this.Moneylabel);
			this.GameMenu.Location = new System.Drawing.Point(2, 292);
			this.GameMenu.Name = "GameMenu";
			this.GameMenu.Size = new System.Drawing.Size(442, 583);
			this.GameMenu.TabIndex = 82;
			this.GameMenu.Visible = false;
			// 
			// ImpositsPanel
			// 
			this.ImpositsPanel.BackColor = System.Drawing.Color.Wheat;
			this.ImpositsPanel.Controls.Add(this.ImpositstextBox);
			this.ImpositsPanel.Controls.Add(this.label11);
			this.ImpositsPanel.Controls.Add(this.label10);
			this.ImpositsPanel.Controls.Add(this.RenttextBox);
			this.ImpositsPanel.Location = new System.Drawing.Point(211, 33);
			this.ImpositsPanel.Name = "ImpositsPanel";
			this.ImpositsPanel.Size = new System.Drawing.Size(209, 294);
			this.ImpositsPanel.TabIndex = 89;
			// 
			// ImpositstextBox
			// 
			this.ImpositstextBox.BackColor = System.Drawing.Color.SteelBlue;
			this.ImpositstextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ImpositstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImpositstextBox.ForeColor = System.Drawing.Color.Red;
			this.ImpositstextBox.Location = new System.Drawing.Point(6, 186);
			this.ImpositstextBox.Multiline = true;
			this.ImpositstextBox.Name = "ImpositstextBox";
			this.ImpositstextBox.ReadOnly = true;
			this.ImpositstextBox.Size = new System.Drawing.Size(193, 105);
			this.ImpositstextBox.TabIndex = 92;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(38, 130);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(110, 18);
			this.label11.TabIndex = 91;
			this.label11.Text = "Daily Income:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(38, 165);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 18);
			this.label10.TabIndex = 90;
			this.label10.Text = "Daily Imposit:";
			// 
			// RenttextBox
			// 
			this.RenttextBox.BackColor = System.Drawing.Color.SteelBlue;
			this.RenttextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RenttextBox.ForeColor = System.Drawing.Color.GreenYellow;
			this.RenttextBox.Location = new System.Drawing.Point(6, 151);
			this.RenttextBox.Name = "RenttextBox";
			this.RenttextBox.ReadOnly = true;
			this.RenttextBox.Size = new System.Drawing.Size(193, 13);
			this.RenttextBox.TabIndex = 6;
			// 
			// Flowinglbl
			// 
			this.Flowinglbl.AutoSize = true;
			this.Flowinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Flowinglbl.Location = new System.Drawing.Point(91, 30);
			this.Flowinglbl.Name = "Flowinglbl";
			this.Flowinglbl.Size = new System.Drawing.Size(45, 18);
			this.Flowinglbl.TabIndex = 88;
			this.Flowinglbl.Text = "Time";
			this.Flowinglbl.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(43, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 18);
			this.label9.TabIndex = 88;
			this.label9.Text = "Day:";
			// 
			// SearchPlayerBtn
			// 
			this.SearchPlayerBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.SearchPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SearchPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchPlayerBtn.ForeColor = System.Drawing.Color.Crimson;
			this.SearchPlayerBtn.Location = new System.Drawing.Point(10, 72);
			this.SearchPlayerBtn.Name = "SearchPlayerBtn";
			this.SearchPlayerBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchPlayerBtn.TabIndex = 11;
			this.SearchPlayerBtn.Text = "Search";
			this.SearchPlayerBtn.UseVisualStyleBackColor = false;
			this.SearchPlayerBtn.Click += new System.EventHandler(this.SearchPlayerBtn_Click);
			// 
			// CentralBoard
			// 
			this.CentralBoard.Location = new System.Drawing.Point(10, 109);
			this.CentralBoard.Name = "CentralBoard";
			this.CentralBoard.Size = new System.Drawing.Size(195, 415);
			this.CentralBoard.TabIndex = 10;
			this.CentralBoard.UseCompatibleStateImageBehavior = false;
			this.CentralBoard.SelectedIndexChanged += new System.EventHandler(this.CentralBoard_SelectedIndexChanged);
			// 
			// PlayersListBoard
			// 
			this.PlayersListBoard.BackColor = System.Drawing.SystemColors.Window;
			this.PlayersListBoard.Cursor = System.Windows.Forms.Cursors.Default;
			this.PlayersListBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayersListBoard.FormattingEnabled = true;
			this.PlayersListBoard.Location = new System.Drawing.Point(89, 74);
			this.PlayersListBoard.Name = "PlayersListBoard";
			this.PlayersListBoard.Size = new System.Drawing.Size(116, 21);
			this.PlayersListBoard.TabIndex = 8;
			this.PlayersListBoard.SelectedIndexChanged += new System.EventHandler(this.PlayersListBoard_SelectedIndexChanged);
			// 
			// DecisionSellPanel
			// 
			this.DecisionSellPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.DecisionSellPanel.Controls.Add(this.OwnerLbl1);
			this.DecisionSellPanel.Controls.Add(this.label5);
			this.DecisionSellPanel.Controls.Add(this.BuildingActualPriceLbl);
			this.DecisionSellPanel.Controls.Add(this.label2);
			this.DecisionSellPanel.Controls.Add(this.BuildingSellValueLbl);
			this.DecisionSellPanel.Controls.Add(this.Sell);
			this.DecisionSellPanel.Controls.Add(this.ItemBoughtBox);
			this.DecisionSellPanel.Controls.Add(this.SellBtn);
			this.DecisionSellPanel.Location = new System.Drawing.Point(144, 208);
			this.DecisionSellPanel.Name = "DecisionSellPanel";
			this.DecisionSellPanel.Size = new System.Drawing.Size(281, 85);
			this.DecisionSellPanel.TabIndex = 84;
			this.DecisionSellPanel.Visible = false;
			// 
			// OwnerLbl1
			// 
			this.OwnerLbl1.AutoSize = true;
			this.OwnerLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OwnerLbl1.Location = new System.Drawing.Point(114, 56);
			this.OwnerLbl1.Name = "OwnerLbl1";
			this.OwnerLbl1.Size = new System.Drawing.Size(51, 16);
			this.OwnerLbl1.TabIndex = 12;
			this.OwnerLbl1.Text = "Owner";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(53, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Owner:";
			// 
			// BuildingActualPriceLbl
			// 
			this.BuildingActualPriceLbl.AutoSize = true;
			this.BuildingActualPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildingActualPriceLbl.Location = new System.Drawing.Point(123, 17);
			this.BuildingActualPriceLbl.Name = "BuildingActualPriceLbl";
			this.BuildingActualPriceLbl.Size = new System.Drawing.Size(39, 16);
			this.BuildingActualPriceLbl.TabIndex = 10;
			this.BuildingActualPriceLbl.Text = "Cost";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Actual Price:";
			// 
			// BuildingSellValueLbl
			// 
			this.BuildingSellValueLbl.AutoSize = true;
			this.BuildingSellValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BuildingSellValueLbl.Location = new System.Drawing.Point(123, 33);
			this.BuildingSellValueLbl.Name = "BuildingSellValueLbl";
			this.BuildingSellValueLbl.Size = new System.Drawing.Size(39, 16);
			this.BuildingSellValueLbl.TabIndex = 8;
			this.BuildingSellValueLbl.Text = "Cost";
			// 
			// Sell
			// 
			this.Sell.AutoSize = true;
			this.Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Sell.Location = new System.Drawing.Point(29, 33);
			this.Sell.Name = "Sell";
			this.Sell.Size = new System.Drawing.Size(79, 16);
			this.Sell.TabIndex = 7;
			this.Sell.Text = "Sell Price:";
			// 
			// ItemBoughtBox
			// 
			this.ItemBoughtBox.BackColor = System.Drawing.Color.YellowGreen;
			this.ItemBoughtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemBoughtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemBoughtBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ItemBoughtBox.Location = new System.Drawing.Point(22, 3);
			this.ItemBoughtBox.Name = "ItemBoughtBox";
			this.ItemBoughtBox.Size = new System.Drawing.Size(243, 13);
			this.ItemBoughtBox.TabIndex = 6;
			this.ItemBoughtBox.Text = "This building is yours.";
			this.ItemBoughtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SellBtn
			// 
			this.SellBtn.BackColor = System.Drawing.Color.CadetBlue;
			this.SellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SellBtn.ForeColor = System.Drawing.Color.Crimson;
			this.SellBtn.Location = new System.Drawing.Point(203, 57);
			this.SellBtn.Name = "SellBtn";
			this.SellBtn.Size = new System.Drawing.Size(75, 25);
			this.SellBtn.TabIndex = 4;
			this.SellBtn.Text = "Sell";
			this.SellBtn.UseVisualStyleBackColor = false;
			this.SellBtn.Click += new System.EventHandler(this.SellBtn_Click);
			// 
			// DecisionSuccessSoldPanel
			// 
			this.DecisionSuccessSoldPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.DecisionSuccessSoldPanel.Controls.Add(this.textBox1);
			this.DecisionSuccessSoldPanel.Location = new System.Drawing.Point(163, 104);
			this.DecisionSuccessSoldPanel.Name = "DecisionSuccessSoldPanel";
			this.DecisionSuccessSoldPanel.Size = new System.Drawing.Size(281, 85);
			this.DecisionSuccessSoldPanel.TabIndex = 85;
			this.DecisionSuccessSoldPanel.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox1.Location = new System.Drawing.Point(23, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(243, 13);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "You successfully sold this building.";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DecisionSuccessBoughtPanel
			// 
			this.DecisionSuccessBoughtPanel.BackColor = System.Drawing.Color.SteelBlue;
			this.DecisionSuccessBoughtPanel.Controls.Add(this.textBox2);
			this.DecisionSuccessBoughtPanel.Location = new System.Drawing.Point(147, 104);
			this.DecisionSuccessBoughtPanel.Name = "DecisionSuccessBoughtPanel";
			this.DecisionSuccessBoughtPanel.Size = new System.Drawing.Size(281, 85);
			this.DecisionSuccessBoughtPanel.TabIndex = 86;
			this.DecisionSuccessBoughtPanel.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.YellowGreen;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox2.Location = new System.Drawing.Point(23, 36);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(243, 13);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "You successfully bought this building.";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DecisionNoMoneyPanel
			// 
			this.DecisionNoMoneyPanel.BackColor = System.Drawing.Color.Red;
			this.DecisionNoMoneyPanel.Controls.Add(this.textBox3);
			this.DecisionNoMoneyPanel.Location = new System.Drawing.Point(134, 13);
			this.DecisionNoMoneyPanel.Name = "DecisionNoMoneyPanel";
			this.DecisionNoMoneyPanel.Size = new System.Drawing.Size(310, 85);
			this.DecisionNoMoneyPanel.TabIndex = 87;
			this.DecisionNoMoneyPanel.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.Yellow;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox3.Location = new System.Drawing.Point(55, 37);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(207, 15);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "NOT ENOUGH MONEY!";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// WONpanel
			// 
			this.WONpanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.WONpanel.BackColor = System.Drawing.Color.Red;
			this.WONpanel.Controls.Add(this.textBox50);
			this.WONpanel.Controls.Add(this.textBoxYW);
			this.WONpanel.Location = new System.Drawing.Point(598, 50);
			this.WONpanel.Name = "WONpanel";
			this.WONpanel.Size = new System.Drawing.Size(300, 100);
			this.WONpanel.TabIndex = 88;
			this.WONpanel.Visible = false;
			// 
			// textBox50
			// 
			this.textBox50.BackColor = System.Drawing.Color.Red;
			this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox50.ForeColor = System.Drawing.Color.White;
			this.textBox50.Location = new System.Drawing.Point(3, 56);
			this.textBox50.Name = "textBox50";
			this.textBox50.ReadOnly = true;
			this.textBox50.Size = new System.Drawing.Size(294, 19);
			this.textBox50.TabIndex = 1;
			this.textBox50.Text = "You own 50% of all buildings";
			this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox50.Visible = false;
			// 
			// textBoxYW
			// 
			this.textBoxYW.BackColor = System.Drawing.Color.Red;
			this.textBoxYW.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxYW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxYW.ForeColor = System.Drawing.Color.White;
			this.textBoxYW.Location = new System.Drawing.Point(42, 28);
			this.textBoxYW.Name = "textBoxYW";
			this.textBoxYW.ReadOnly = true;
			this.textBoxYW.Size = new System.Drawing.Size(206, 19);
			this.textBoxYW.TabIndex = 0;
			this.textBoxYW.Text = "YOU WON";
			this.textBoxYW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxYW.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(543, 424);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(950, 23);
			this.progressBar1.TabIndex = 0;
			this.progressBar1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1900, 869);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.WONpanel);
			this.Controls.Add(this.DecisionNoMoneyPanel);
			this.Controls.Add(this.DecisionSuccessBoughtPanel);
			this.Controls.Add(this.DecisionSuccessSoldPanel);
			this.Controls.Add(this.DecisionSellPanel);
			this.Controls.Add(this.AvNGPanel);
			this.Controls.Add(this.AvQGPanel);
			this.Controls.Add(this.GameMenu);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.NewGameMenu);
			this.Controls.Add(this.StartMenu);
			this.Controls.Add(this.DecisionBuyPanel);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.ForeColor = System.Drawing.Color.Crimson;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "LandLord";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.AvQGPanel.ResumeLayout(false);
			this.AvQGPanel.PerformLayout();
			this.AvNGPanel.ResumeLayout(false);
			this.AvNGPanel.PerformLayout();
			this.DecisionBuyPanel.ResumeLayout(false);
			this.DecisionBuyPanel.PerformLayout();
			this.StartMenu.ResumeLayout(false);
			this.NewGameMenu.ResumeLayout(false);
			this.NewGameMenu.PerformLayout();
			this.GameMenu.ResumeLayout(false);
			this.GameMenu.PerformLayout();
			this.ImpositsPanel.ResumeLayout(false);
			this.ImpositsPanel.PerformLayout();
			this.DecisionSellPanel.ResumeLayout(false);
			this.DecisionSellPanel.PerformLayout();
			this.DecisionSuccessSoldPanel.ResumeLayout(false);
			this.DecisionSuccessSoldPanel.PerformLayout();
			this.DecisionSuccessBoughtPanel.ResumeLayout(false);
			this.DecisionSuccessBoughtPanel.PerformLayout();
			this.DecisionNoMoneyPanel.ResumeLayout(false);
			this.DecisionNoMoneyPanel.PerformLayout();
			this.WONpanel.ResumeLayout(false);
			this.WONpanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitGameBtn;
        private System.Windows.Forms.Label Moneylabel;
        private System.Windows.Forms.Label MoneyDisplaylabel;
        private System.Windows.Forms.Timer Timeflow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameItem;
        private System.Windows.Forms.ToolStripMenuItem QuitGameItem;
        private System.Windows.Forms.Button LoadGameBtn;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel AvQGPanel;
        private System.Windows.Forms.TextBox AvQGTB;
        private System.Windows.Forms.Button QGCancelBtn;
        private System.Windows.Forms.Button QGLeaveBtn;
        private System.Windows.Forms.Panel AvNGPanel;
        private System.Windows.Forms.TextBox AvNGTB;
        private System.Windows.Forms.Button NGCancelBtn;
        private System.Windows.Forms.Button NGLeaveBtn;
        private System.Windows.Forms.Panel DecisionBuyPanel;
        private System.Windows.Forms.Panel StartMenu;
        private System.Windows.Forms.Panel NewGameMenu;
        private System.Windows.Forms.Panel GameMenu;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.TextBox DecisionBuyBox;
        private System.Windows.Forms.Button ExitAppBtn;
        private System.Windows.Forms.Label BuildingBuyValueLbl;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel DecisionSellPanel;
		private System.Windows.Forms.Label BuildingSellValueLbl;
		private System.Windows.Forms.Label Sell;
		private System.Windows.Forms.TextBox ItemBoughtBox;
		private System.Windows.Forms.Button SellBtn;
		private System.Windows.Forms.Label BuildingActualPriceLbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel DecisionSuccessSoldPanel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel DecisionSuccessBoughtPanel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox InitialMoneyComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel DecisionNoMoneyPanel;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox PlayerColorComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label OwnerLbl2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label OwnerLbl1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PNameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListView CentralBoard;
		private System.Windows.Forms.ComboBox PlayersListBoard;
		private System.Windows.Forms.Button SearchPlayerBtn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label Flowinglbl;
		private System.Windows.Forms.Panel WONpanel;
		private System.Windows.Forms.TextBox textBox50;
		private System.Windows.Forms.TextBox textBoxYW;
		private System.Windows.Forms.ComboBox BotNumberComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel ImpositsPanel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox RenttextBox;
		private System.Windows.Forms.TextBox ImpositstextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

