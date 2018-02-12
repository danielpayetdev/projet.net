﻿using System.Windows.Forms;
using Projet.Net.model;
using System.Drawing;

namespace Projet.Net
{
    partial class AppWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.EditionDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.ouvrirUnWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerDesImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.leftApp = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutGauche = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutSearchTags = new System.Windows.Forms.FlowLayoutPanel();
            this.tagSearch = new System.Windows.Forms.TextBox();
            this.eraseTagSearch = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.ListBox();
            this.MosaiqueImages = new System.Windows.Forms.FlowLayoutPanel();
            this.importerImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuBar.SuspendLayout();
            this.flowLayoutGauche.SuspendLayout();
            this.flowLayoutSearchTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditionDropDown,
            this.toolStripSeparator,
            this.leftApp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(875, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "toolStrip1";
            // 
            // EditionDropDown
            // 
            this.EditionDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditionDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnWorkspaceToolStripMenuItem,
            this.importerDesImagesToolStripMenuItem});
            this.EditionDropDown.Image = ((System.Drawing.Image)(resources.GetObject("EditionDropDown.Image")));
            this.EditionDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditionDropDown.Name = "EditionDropDown";
            this.EditionDropDown.Size = new System.Drawing.Size(57, 22);
            this.EditionDropDown.Text = "Edition";
            this.EditionDropDown.ToolTipText = "Edition";
            // 
            // ouvrirUnWorkspaceToolStripMenuItem
            // 
            this.ouvrirUnWorkspaceToolStripMenuItem.Name = "ouvrirUnWorkspaceToolStripMenuItem";
            this.ouvrirUnWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ouvrirUnWorkspaceToolStripMenuItem.Text = "Ouvrir un dossier de travail";
            this.ouvrirUnWorkspaceToolStripMenuItem.ToolTipText = "Ouvrir un nouveau dossier de travail";
            // 
            // importerDesImagesToolStripMenuItem
            // 
            this.importerDesImagesToolStripMenuItem.Name = "importerDesImagesToolStripMenuItem";
            this.importerDesImagesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.importerDesImagesToolStripMenuItem.Text = "Importer des images";
            this.importerDesImagesToolStripMenuItem.ToolTipText = "Importer des images dans le dossier actuel";
            this.importerDesImagesToolStripMenuItem.Click += new System.EventHandler(this.importerDesImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // leftApp
            // 
            this.leftApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftApp.Image = ((System.Drawing.Image)(resources.GetObject("leftApp.Image")));
            this.leftApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftApp.Name = "leftApp";
            this.leftApp.Size = new System.Drawing.Size(48, 22);
            this.leftApp.Text = "Quitter";
            this.leftApp.Click += new System.EventHandler(this.leftAppButton_Click);
            // 
            // flowLayoutLeft
            // 
            this.flowLayoutLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutLeft.Location = new System.Drawing.Point(715, 25);
            this.flowLayoutLeft.Name = "flowLayoutLeft";
            this.flowLayoutLeft.Size = new System.Drawing.Size(160, 433);
            this.flowLayoutLeft.TabIndex = 7;
            this.flowLayoutLeft.WrapContents = false;
            // 
            // flowLayoutGauche
            // 
            this.flowLayoutGauche.Controls.Add(this.flowLayoutSearchTags);
            this.flowLayoutGauche.Controls.Add(this.tags);
            this.flowLayoutGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutGauche.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutGauche.Name = "flowLayoutGauche";
            this.flowLayoutGauche.Size = new System.Drawing.Size(200, 433);
            this.flowLayoutGauche.TabIndex = 6;
            // 
            // flowLayoutSearchTags
            // 
            this.flowLayoutSearchTags.Controls.Add(this.tagSearch);
            this.flowLayoutSearchTags.Controls.Add(this.eraseTagSearch);
            this.flowLayoutSearchTags.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutSearchTags.Name = "flowLayoutSearchTags";
            this.flowLayoutSearchTags.Size = new System.Drawing.Size(191, 27);
            this.flowLayoutSearchTags.TabIndex = 0;
            // 
            // tagSearch
            // 
            this.tagSearch.Location = new System.Drawing.Point(3, 3);
            this.tagSearch.Name = "tagSearch";
            this.tagSearch.Size = new System.Drawing.Size(147, 20);
            this.tagSearch.TabIndex = 2;
            this.tagSearch.TextChanged += new System.EventHandler(this.tagSearch_TextChanged);
            // 
            // eraseTagSearch
            // 
            this.eraseTagSearch.Location = new System.Drawing.Point(156, 3);
            this.eraseTagSearch.Name = "eraseTagSearch";
            this.eraseTagSearch.Size = new System.Drawing.Size(28, 21);
            this.eraseTagSearch.TabIndex = 3;
            this.eraseTagSearch.Text = "X";
            this.eraseTagSearch.UseVisualStyleBackColor = true;
            this.eraseTagSearch.Click += new System.EventHandler(this.eraseTagSearch_Click);
            // 
            // tags
            // 
            this.tags.FormattingEnabled = true;
            this.tags.Location = new System.Drawing.Point(5, 38);
            this.tags.Margin = new System.Windows.Forms.Padding(5);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(189, 381);
            this.tags.TabIndex = 5;
            this.tags.SelectedIndexChanged += new System.EventHandler(this.tags_SelectedIndexChanged);
            // 
            // MosaiqueImages
            // 
            this.MosaiqueImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MosaiqueImages.Location = new System.Drawing.Point(200, 25);
            this.MosaiqueImages.Name = "MosaiqueImages";
            this.MosaiqueImages.Size = new System.Drawing.Size(515, 433);
            this.MosaiqueImages.TabIndex = 6;
            // 
            // importerImageDialog
            // 
            this.importerImageDialog.FileName = "importerImageDialog";
            this.importerImageDialog.Filter = "Images (*.jpg)|*.jpg";
            this.importerImageDialog.Multiselect = true;
            this.importerImageDialog.Title = "Sélection des fichiers à copier dans le workspace";
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 458);
            this.Controls.Add(this.MosaiqueImages);
            this.Controls.Add(this.flowLayoutGauche);
            this.Controls.Add(this.flowLayoutLeft);
            this.Controls.Add(this.menuBar);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "AppWindow";
            this.Text = "Photo Tagger";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.flowLayoutGauche.ResumeLayout(false);
            this.flowLayoutSearchTags.ResumeLayout(false);
            this.flowLayoutSearchTags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton leftApp;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripDropDownButton EditionDropDown;
        private ToolStripMenuItem ouvrirUnWorkspaceToolStripMenuItem;
        private ToolStripMenuItem importerDesImagesToolStripMenuItem;
        private FlowLayoutPanel flowLayoutLeft;
        private FlowLayoutPanel flowLayoutGauche;
        private FlowLayoutPanel flowLayoutSearchTags;
        private TextBox tagSearch;
        private Button eraseTagSearch;
        private ListBox tags;
        private FlowLayoutPanel MosaiqueImages;
        private OpenFileDialog importerImageDialog;
    }
}

