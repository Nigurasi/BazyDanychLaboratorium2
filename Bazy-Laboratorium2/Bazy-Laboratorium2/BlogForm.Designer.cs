namespace Bazy_Laboratorium2
{
    partial class BlogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Bazy_Laboratorium2_BloggingContextDataSet = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSet();
            this.dataSet1 = new Bazy_Laboratorium2.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.blogsTableAdapter = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSetTableAdapters.BlogsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blogIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Bazy_Laboratorium2_BloggingContextDataSet1 = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSet1();
            this.postsTableAdapter = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSet1TableAdapters.PostsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.blogIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Bazy_Laboratorium2_BloggingContextDataSet2 = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSet2();
            this.authorsTableAdapter = new Bazy_Laboratorium2._Bazy_Laboratorium2_BloggingContextDataSet2TableAdapters.AuthorsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Label();
            this.StatsInfo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.wantedTopic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foundBlogs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blogIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.blogsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // blogIdDataGridViewTextBoxColumn
            // 
            this.blogIdDataGridViewTextBoxColumn.DataPropertyName = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.HeaderText = "BlogId";
            this.blogIdDataGridViewTextBoxColumn.Name = "blogIdDataGridViewTextBoxColumn";
            this.blogIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this._Bazy_Laboratorium2_BloggingContextDataSet;
            // 
            // _Bazy_Laboratorium2_BloggingContextDataSet
            // 
            this._Bazy_Laboratorium2_BloggingContextDataSet.DataSetName = "_Bazy_Laboratorium2_BloggingContextDataSet";
            this._Bazy_Laboratorium2_BloggingContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // blogsTableAdapter
            // 
            this.blogsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.postIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.blogIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.postsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(470, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // blogIdDataGridViewTextBoxColumn1
            // 
            this.blogIdDataGridViewTextBoxColumn1.DataPropertyName = "BlogId";
            this.blogIdDataGridViewTextBoxColumn1.HeaderText = "BlogId";
            this.blogIdDataGridViewTextBoxColumn1.Name = "blogIdDataGridViewTextBoxColumn1";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this._Bazy_Laboratorium2_BloggingContextDataSet1;
            // 
            // _Bazy_Laboratorium2_BloggingContextDataSet1
            // 
            this._Bazy_Laboratorium2_BloggingContextDataSet1.DataSetName = "_Bazy_Laboratorium2_BloggingContextDataSet1";
            this._Bazy_Laboratorium2_BloggingContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blogIdDataGridViewTextBoxColumn2,
            this.userNameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.authorsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 189);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(470, 150);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.Visible = false;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // blogIdDataGridViewTextBoxColumn2
            // 
            this.blogIdDataGridViewTextBoxColumn2.DataPropertyName = "BlogId";
            this.blogIdDataGridViewTextBoxColumn2.HeaderText = "BlogId";
            this.blogIdDataGridViewTextBoxColumn2.Name = "blogIdDataGridViewTextBoxColumn2";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this._Bazy_Laboratorium2_BloggingContextDataSet2;
            // 
            // _Bazy_Laboratorium2_BloggingContextDataSet2
            // 
            this._Bazy_Laboratorium2_BloggingContextDataSet2.DataSetName = "_Bazy_Laboratorium2_BloggingContextDataSet2";
            this._Bazy_Laboratorium2_BloggingContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Authors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics
            // 
            this.Statistics.AutoSize = true;
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Statistics.Location = new System.Drawing.Point(473, 245);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(68, 17);
            this.Statistics.TabIndex = 6;
            this.Statistics.Text = "Statistics:";
            // 
            // StatsInfo
            // 
            this.StatsInfo.AutoSize = true;
            this.StatsInfo.Location = new System.Drawing.Point(476, 276);
            this.StatsInfo.Name = "StatsInfo";
            this.StatsInfo.Size = new System.Drawing.Size(38, 13);
            this.StatsInfo.TabIndex = 7;
            this.StatsInfo.Text = "NONE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wantedTopic
            // 
            this.wantedTopic.Location = new System.Drawing.Point(501, 25);
            this.wantedTopic.Name = "wantedTopic";
            this.wantedTopic.Size = new System.Drawing.Size(165, 20);
            this.wantedTopic.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(476, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Blogs with interesting topic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(473, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Found Blogs:";
            // 
            // foundBlogs
            // 
            this.foundBlogs.AutoSize = true;
            this.foundBlogs.Location = new System.Drawing.Point(473, 162);
            this.foundBlogs.Name = "foundBlogs";
            this.foundBlogs.Size = new System.Drawing.Size(84, 13);
            this.foundBlogs.TabIndex = 12;
            this.foundBlogs.Text = "Search for blogs";
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 384);
            this.Controls.Add(this.foundBlogs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wantedTopic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StatsInfo);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BlogForm";
            this.Text = "BlogForm";
            this.Load += new System.EventHandler(this.BlogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Bazy_Laboratorium2_BloggingContextDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private _Bazy_Laboratorium2_BloggingContextDataSet _Bazy_Laboratorium2_BloggingContextDataSet;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private _Bazy_Laboratorium2_BloggingContextDataSetTableAdapters.BlogsTableAdapter blogsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _Bazy_Laboratorium2_BloggingContextDataSet1 _Bazy_Laboratorium2_BloggingContextDataSet1;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private _Bazy_Laboratorium2_BloggingContextDataSet1TableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private _Bazy_Laboratorium2_BloggingContextDataSet2 _Bazy_Laboratorium2_BloggingContextDataSet2;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private _Bazy_Laboratorium2_BloggingContextDataSet2TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn blogIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Statistics;
        private System.Windows.Forms.Label StatsInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox wantedTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label foundBlogs;
    }
}