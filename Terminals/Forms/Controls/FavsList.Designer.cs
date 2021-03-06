﻿namespace Terminals.Forms.Controls
{
    partial class FavsList
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
        	this.components = new System.ComponentModel.Container();
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.connectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.userConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
        	this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.dNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.traceRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.tSAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
        	this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
        	this.computerManagementMMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
        	this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
        	this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.FavoritesTabPage = new System.Windows.Forms.TabPage();
        	this.favsTree = new Terminals.Forms.Controls.FavoritesTreeView();
        	this.DatabaseTabPage = new System.Windows.Forms.TabPage();
        	this.dbTreeView1 = new Terminals.Forms.Controls.DBTreeView();
        	this.HistoryTabPage = new System.Windows.Forms.TabPage();
        	this.historyTreeView = new Terminals.Forms.Controls.HistoryTreeView();
        	this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.connectToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.consoleAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newWindowAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.setCredentialByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.setUsernameByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.setDomainByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.setPasswordByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.deleteAllFavoritesByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.contextMenuStrip1.SuspendLayout();
        	this.tabControl1.SuspendLayout();
        	this.FavoritesTabPage.SuspendLayout();
        	this.DatabaseTabPage.SuspendLayout();
        	this.HistoryTabPage.SuspendLayout();
        	this.contextMenuStrip2.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.connectToolStripMenuItem,
			this.toolStripMenuItem2,
			this.pingToolStripMenuItem,
			this.dNSToolStripMenuItem,
			this.traceRouteToolStripMenuItem,
			this.tSAdminToolStripMenuItem,
			this.toolStripMenuItem1,
			this.rebootToolStripMenuItem,
			this.shutdownToolStripMenuItem,
			this.toolStripMenuItem4,
			this.computerManagementMMCToolStripMenuItem,
			this.systemInformationToolStripMenuItem,
			this.toolStripMenuItem3,
			this.copyToolStripMenuItem,
			this.deleteToolStripMenuItem,
			this.toolStripMenuItem5,
			this.propertiesToolStripMenuItem});
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(244, 298);
        	// 
        	// connectToolStripMenuItem
        	// 
        	this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.consoleToolStripMenuItem,
			this.newWindowToolStripMenuItem,
			this.toolStripSeparator2,
			this.connectAsToolStripMenuItem});
        	this.connectToolStripMenuItem.Image = global::Terminals.Properties.Resources.application_lightning;
        	this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
        	this.connectToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.connectToolStripMenuItem.Text = "Connect";
        	this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
        	// 
        	// consoleToolStripMenuItem
        	// 
        	this.consoleToolStripMenuItem.CheckOnClick = true;
        	this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
        	this.consoleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.consoleToolStripMenuItem.Text = "Console";
        	this.consoleToolStripMenuItem.Click += new System.EventHandler(this.displayWindow_Click);
        	// 
        	// newWindowToolStripMenuItem
        	// 
        	this.newWindowToolStripMenuItem.CheckOnClick = true;
        	this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
        	this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.newWindowToolStripMenuItem.Text = "New Window";
        	this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.displayWindow_Click);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(142, 6);
        	// 
        	// connectAsToolStripMenuItem
        	// 
        	this.connectAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.userConnectToolStripMenuItem});
        	this.connectAsToolStripMenuItem.Name = "connectAsToolStripMenuItem";
        	this.connectAsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.connectAsToolStripMenuItem.Text = "Connect As";
        	this.connectAsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.connectAsToolStripMenuItem_DropDownOpening);
        	// 
        	// userConnectToolStripMenuItem
        	// 
        	this.userConnectToolStripMenuItem.Name = "userConnectToolStripMenuItem";
        	this.userConnectToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
        	this.userConnectToolStripMenuItem.Text = "User...";
        	this.userConnectToolStripMenuItem.Click += new System.EventHandler(this.userConnectToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem2
        	// 
        	this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        	this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 6);
        	// 
        	// pingToolStripMenuItem
        	// 
        	this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
        	this.pingToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.pingToolStripMenuItem.Text = "Ping";
        	this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
        	// 
        	// dNSToolStripMenuItem
        	// 
        	this.dNSToolStripMenuItem.Name = "dNSToolStripMenuItem";
        	this.dNSToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.dNSToolStripMenuItem.Text = "DNS";
        	this.dNSToolStripMenuItem.Click += new System.EventHandler(this.dNSToolStripMenuItem_Click);
        	// 
        	// traceRouteToolStripMenuItem
        	// 
        	this.traceRouteToolStripMenuItem.Name = "traceRouteToolStripMenuItem";
        	this.traceRouteToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.traceRouteToolStripMenuItem.Text = "Trace Route";
        	this.traceRouteToolStripMenuItem.Click += new System.EventHandler(this.traceRouteToolStripMenuItem_Click);
        	// 
        	// tSAdminToolStripMenuItem
        	// 
        	this.tSAdminToolStripMenuItem.Name = "tSAdminToolStripMenuItem";
        	this.tSAdminToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.tSAdminToolStripMenuItem.Text = "TS Admin";
        	this.tSAdminToolStripMenuItem.Click += new System.EventHandler(this.tSAdminToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 6);
        	// 
        	// rebootToolStripMenuItem
        	// 
        	this.rebootToolStripMenuItem.Image = global::Terminals.Properties.Resources.perspective_button_reboot;
        	this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
        	this.rebootToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.rebootToolStripMenuItem.Text = "Reboot";
        	this.rebootToolStripMenuItem.Click += new System.EventHandler(this.ShutdownToolStripMenuItem_Click);
        	// 
        	// shutdownToolStripMenuItem
        	// 
        	this.shutdownToolStripMenuItem.Image = global::Terminals.Properties.Resources.perspective_button_shutdown;
        	this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
        	this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.shutdownToolStripMenuItem.Text = "Shutdown";
        	this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.ShutdownToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem4
        	// 
        	this.toolStripMenuItem4.Name = "toolStripMenuItem4";
        	this.toolStripMenuItem4.Size = new System.Drawing.Size(240, 6);
        	// 
        	// computerManagementMMCToolStripMenuItem
        	// 
        	this.computerManagementMMCToolStripMenuItem.Image = global::Terminals.Properties.Resources.computermgmt;
        	this.computerManagementMMCToolStripMenuItem.Name = "computerManagementMMCToolStripMenuItem";
        	this.computerManagementMMCToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.computerManagementMMCToolStripMenuItem.Text = "Computer Management (MMC)";
        	this.computerManagementMMCToolStripMenuItem.Click += new System.EventHandler(this.computerManagementMMCToolStripMenuItem_Click);
        	// 
        	// systemInformationToolStripMenuItem
        	// 
        	this.systemInformationToolStripMenuItem.Image = global::Terminals.Properties.Resources.Information;
        	this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
        	this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.systemInformationToolStripMenuItem.Text = "System Information";
        	this.systemInformationToolStripMenuItem.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem3
        	// 
        	this.toolStripMenuItem3.Name = "toolStripMenuItem3";
        	this.toolStripMenuItem3.Size = new System.Drawing.Size(240, 6);
        	// 
        	// copyToolStripMenuItem
        	// 
        	this.copyToolStripMenuItem.Image = global::Terminals.Properties.Resources.Copy;
        	this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        	this.copyToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.copyToolStripMenuItem.Text = "Copy";
        	this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Image = global::Terminals.Properties.Resources.delete;
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.deleteToolStripMenuItem.Text = "Delete";
        	this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
        	// 
        	// toolStripMenuItem5
        	// 
        	this.toolStripMenuItem5.Name = "toolStripMenuItem5";
        	this.toolStripMenuItem5.Size = new System.Drawing.Size(240, 6);
        	// 
        	// propertiesToolStripMenuItem
        	// 
        	this.propertiesToolStripMenuItem.Image = global::Terminals.Properties.Resources.Properties;
        	this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
        	this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
        	this.propertiesToolStripMenuItem.Text = "Properties";
        	this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(this.FavoritesTabPage);
        	this.tabControl1.Controls.Add(this.DatabaseTabPage);
        	this.tabControl1.Controls.Add(this.HistoryTabPage);
        	this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tabControl1.Location = new System.Drawing.Point(0, 0);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.ShowToolTips = true;
        	this.tabControl1.Size = new System.Drawing.Size(150, 150);
        	this.tabControl1.TabIndex = 1;
        	// 
        	// FavoritesTabPage
        	// 
        	this.FavoritesTabPage.Controls.Add(this.favsTree);
        	this.FavoritesTabPage.Location = new System.Drawing.Point(4, 22);
        	this.FavoritesTabPage.Name = "FavoritesTabPage";
        	this.FavoritesTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.FavoritesTabPage.Size = new System.Drawing.Size(142, 124);
        	this.FavoritesTabPage.TabIndex = 0;
        	this.FavoritesTabPage.Text = "Favorites";
        	this.FavoritesTabPage.UseVisualStyleBackColor = true;
        	// 
        	// favsTree
        	// 
        	this.favsTree.AllowDrop = true;
        	this.favsTree.CausesValidation = false;
        	this.favsTree.ContextMenuStrip = this.contextMenuStrip1;
        	this.favsTree.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.favsTree.HideSelection = false;
        	this.favsTree.HotTracking = true;
        	this.favsTree.Location = new System.Drawing.Point(3, 3);
        	this.favsTree.Name = "favsTree";
        	this.favsTree.ShowNodeToolTips = true;
        	this.favsTree.Size = new System.Drawing.Size(136, 118);
        	this.favsTree.TabIndex = 0;
        	this.favsTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
        	this.favsTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
        	this.favsTree.DoubleClick += new System.EventHandler(this.TreeView_DoubleClick);
        	this.favsTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FavsTreeKeyUp);
        	// 
        	// DatabaseTabPage
        	// 
        	this.DatabaseTabPage.Controls.Add(this.dbTreeView1);
        	this.DatabaseTabPage.Location = new System.Drawing.Point(4, 22);
        	this.DatabaseTabPage.Name = "DatabaseTabPage";
        	this.DatabaseTabPage.Size = new System.Drawing.Size(142, 124);
        	this.DatabaseTabPage.TabIndex = 2;
        	this.DatabaseTabPage.Text = "Database";
        	this.DatabaseTabPage.UseVisualStyleBackColor = true;
        	// 
        	// dbTreeView1
        	// 
        	this.dbTreeView1.AllowDrop = true;
        	this.dbTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        	this.dbTreeView1.CausesValidation = false;
        	this.dbTreeView1.ContextMenuStrip = this.contextMenuStrip1;
        	this.dbTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dbTreeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dbTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        	this.dbTreeView1.ImageIndex = 0;
        	this.dbTreeView1.Location = new System.Drawing.Point(0, 0);
        	this.dbTreeView1.Name = "dbTreeView1";
        	this.dbTreeView1.SelectedImageIndex = 0;
        	this.dbTreeView1.ShowNodeToolTips = true;
        	this.dbTreeView1.Size = new System.Drawing.Size(142, 124);
        	this.dbTreeView1.TabIndex = 0;
        	this.dbTreeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
        	this.dbTreeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
        	this.dbTreeView1.DoubleClick += new System.EventHandler(this.TreeView_DoubleClick);
        	this.dbTreeView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FavsTreeKeyUp);
        	// 
        	// HistoryTabPage
        	// 
        	this.HistoryTabPage.Controls.Add(this.historyTreeView);
        	this.HistoryTabPage.Location = new System.Drawing.Point(4, 22);
        	this.HistoryTabPage.Name = "HistoryTabPage";
        	this.HistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
        	this.HistoryTabPage.Size = new System.Drawing.Size(142, 124);
        	this.HistoryTabPage.TabIndex = 1;
        	this.HistoryTabPage.Text = "History";
        	this.HistoryTabPage.UseVisualStyleBackColor = true;
        	// 
        	// historyTreeView
        	// 
        	this.historyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.historyTreeView.HotTracking = true;
        	this.historyTreeView.ImageIndex = 0;
        	this.historyTreeView.Location = new System.Drawing.Point(3, 3);
        	this.historyTreeView.Name = "historyTreeView";
        	this.historyTreeView.SelectedImageIndex = 0;
        	this.historyTreeView.ShowNodeToolTips = true;
        	this.historyTreeView.Size = new System.Drawing.Size(136, 118);
        	this.historyTreeView.TabIndex = 0;
        	this.historyTreeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.historyTreeView_KeyUp);
        	// 
        	// contextMenuStrip2
        	// 
        	this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.connectToAllToolStripMenuItem,
			this.toolStripSeparator1,
			this.setCredentialByTagToolStripMenuItem,
			this.setUsernameByTagToolStripMenuItem,
			this.setDomainByTagToolStripMenuItem,
			this.setPasswordByTagToolStripMenuItem,
			this.deleteAllFavoritesByTagToolStripMenuItem});
        	this.contextMenuStrip2.Name = "contextMenuStrip2";
        	this.contextMenuStrip2.Size = new System.Drawing.Size(212, 142);
        	// 
        	// connectToAllToolStripMenuItem
        	// 
        	this.connectToAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.consoleAllToolStripMenuItem,
			this.newWindowAllToolStripMenuItem});
        	this.connectToAllToolStripMenuItem.Image = global::Terminals.Properties.Resources.application_lightning;
        	this.connectToAllToolStripMenuItem.Name = "connectToAllToolStripMenuItem";
        	this.connectToAllToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.connectToAllToolStripMenuItem.Text = "Connect to All";
        	this.connectToAllToolStripMenuItem.Click += new System.EventHandler(this.connectToAllToolStripMenuItem_Click);
        	// 
        	// consoleAllToolStripMenuItem
        	// 
        	this.consoleAllToolStripMenuItem.CheckOnClick = true;
        	this.consoleAllToolStripMenuItem.Name = "consoleAllToolStripMenuItem";
        	this.consoleAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.consoleAllToolStripMenuItem.Text = "Console";
        	this.consoleAllToolStripMenuItem.Click += new System.EventHandler(this.displayAllWindow_Click);
        	// 
        	// newWindowAllToolStripMenuItem
        	// 
        	this.newWindowAllToolStripMenuItem.CheckOnClick = true;
        	this.newWindowAllToolStripMenuItem.Name = "newWindowAllToolStripMenuItem";
        	this.newWindowAllToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        	this.newWindowAllToolStripMenuItem.Text = "New Window";
        	this.newWindowAllToolStripMenuItem.Click += new System.EventHandler(this.displayAllWindow_Click);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
        	// 
        	// setCredentialByTagToolStripMenuItem
        	// 
        	this.setCredentialByTagToolStripMenuItem.Name = "setCredentialByTagToolStripMenuItem";
        	this.setCredentialByTagToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.setCredentialByTagToolStripMenuItem.Text = "Set Credential by Tag";
        	this.setCredentialByTagToolStripMenuItem.Click += new System.EventHandler(this.setCredentialByTagToolStripMenuItem_Click);
        	// 
        	// setUsernameByTagToolStripMenuItem
        	// 
        	this.setUsernameByTagToolStripMenuItem.Name = "setUsernameByTagToolStripMenuItem";
        	this.setUsernameByTagToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.setUsernameByTagToolStripMenuItem.Text = "Set Username by Tag";
        	this.setUsernameByTagToolStripMenuItem.Click += new System.EventHandler(this.setUsernameByTagToolStripMenuItem_Click);
        	// 
        	// setDomainByTagToolStripMenuItem
        	// 
        	this.setDomainByTagToolStripMenuItem.Name = "setDomainByTagToolStripMenuItem";
        	this.setDomainByTagToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.setDomainByTagToolStripMenuItem.Text = "Set Domain by Tag";
        	this.setDomainByTagToolStripMenuItem.Click += new System.EventHandler(this.setDomainByTagToolStripMenuItem_Click);
        	// 
        	// setPasswordByTagToolStripMenuItem
        	// 
        	this.setPasswordByTagToolStripMenuItem.Name = "setPasswordByTagToolStripMenuItem";
        	this.setPasswordByTagToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.setPasswordByTagToolStripMenuItem.Text = "Set Password by Tag";
        	this.setPasswordByTagToolStripMenuItem.Click += new System.EventHandler(this.setPasswordByTagToolStripMenuItem_Click);
        	// 
        	// deleteAllFavoritesByTagToolStripMenuItem
        	// 
        	this.deleteAllFavoritesByTagToolStripMenuItem.Name = "deleteAllFavoritesByTagToolStripMenuItem";
        	this.deleteAllFavoritesByTagToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
        	this.deleteAllFavoritesByTagToolStripMenuItem.Text = "Delete all Favorites by Tag";
        	this.deleteAllFavoritesByTagToolStripMenuItem.Click += new System.EventHandler(this.deleteAllFavoritesByTagToolStripMenuItem_Click);
        	// 
        	// FavsList
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.tabControl1);
        	this.Name = "FavsList";
        	this.Load += new System.EventHandler(this.FavsList_Load);
        	this.contextMenuStrip1.ResumeLayout(false);
        	this.tabControl1.ResumeLayout(false);
        	this.FavoritesTabPage.ResumeLayout(false);
        	this.DatabaseTabPage.ResumeLayout(false);
        	this.HistoryTabPage.ResumeLayout(false);
        	this.contextMenuStrip2.ResumeLayout(false);
        	this.ResumeLayout(false);

        }

        #endregion

        private Terminals.Forms.Controls.FavoritesTreeView favsTree;        
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traceRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerManagementMMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FavoritesTabPage;
        private System.Windows.Forms.TabPage HistoryTabPage;
        private Terminals.Forms.Controls.HistoryTreeView historyTreeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem connectToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setCredentialByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUsernameByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDomainByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPasswordByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllFavoritesByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage DatabaseTabPage;
        private DBTreeView dbTreeView1;
    }
}
