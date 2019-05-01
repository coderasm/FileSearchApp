namespace StringSearchApp
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
      this.button1 = new System.Windows.Forms.Button();
      this.filePath = new System.Windows.Forms.Label();
      this.searchTextBox = new System.Windows.Forms.TextBox();
      this.searchTextLabel = new System.Windows.Forms.Label();
      this.searchButton = new System.Windows.Forms.Button();
      this.resultLabel = new System.Windows.Forms.Label();
      this.resultsCount = new System.Windows.Forms.Label();
      this.resultList = new System.Windows.Forms.ListBox();
      this.previousButton = new System.Windows.Forms.Button();
      this.nextButton = new System.Windows.Forms.Button();
      this.firstButton = new System.Windows.Forms.Button();
      this.lastButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(67, 22);
      this.button1.TabIndex = 0;
      this.button1.Text = "Load";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.loadButtonClicked);
      // 
      // filePath
      // 
      this.filePath.AutoSize = true;
      this.filePath.Location = new System.Drawing.Point(85, 17);
      this.filePath.Name = "filePath";
      this.filePath.Size = new System.Drawing.Size(82, 13);
      this.filePath.TabIndex = 1;
      this.filePath.Text = "Select a text file";
      // 
      // searchTextBox
      // 
      this.searchTextBox.Location = new System.Drawing.Point(12, 55);
      this.searchTextBox.Name = "searchTextBox";
      this.searchTextBox.Size = new System.Drawing.Size(119, 20);
      this.searchTextBox.TabIndex = 2;
      // 
      // searchTextLabel
      // 
      this.searchTextLabel.AutoSize = true;
      this.searchTextLabel.Location = new System.Drawing.Point(12, 39);
      this.searchTextLabel.Name = "searchTextLabel";
      this.searchTextLabel.Size = new System.Drawing.Size(65, 13);
      this.searchTextLabel.TabIndex = 3;
      this.searchTextLabel.Text = "Search Text";
      // 
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(12, 81);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 23);
      this.searchButton.TabIndex = 4;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButtonClicked);
      // 
      // resultLabel
      // 
      this.resultLabel.AutoSize = true;
      this.resultLabel.Location = new System.Drawing.Point(541, 42);
      this.resultLabel.Name = "resultLabel";
      this.resultLabel.Size = new System.Drawing.Size(45, 13);
      this.resultLabel.TabIndex = 5;
      this.resultLabel.Text = "Results:";
      // 
      // resultsCount
      // 
      this.resultsCount.AutoSize = true;
      this.resultsCount.Location = new System.Drawing.Point(581, 42);
      this.resultsCount.Name = "resultsCount";
      this.resultsCount.Size = new System.Drawing.Size(13, 13);
      this.resultsCount.TabIndex = 6;
      this.resultsCount.Text = "0";
      // 
      // resultList
      // 
      this.resultList.FormattingEnabled = true;
      this.resultList.Location = new System.Drawing.Point(157, 65);
      this.resultList.Name = "resultList";
      this.resultList.Size = new System.Drawing.Size(852, 563);
      this.resultList.TabIndex = 7;
      // 
      // previousButton
      // 
      this.previousButton.Location = new System.Drawing.Point(81, 110);
      this.previousButton.Name = "previousButton";
      this.previousButton.Size = new System.Drawing.Size(63, 23);
      this.previousButton.TabIndex = 8;
      this.previousButton.Text = "Previous";
      this.previousButton.UseVisualStyleBackColor = true;
      this.previousButton.Click += new System.EventHandler(this.previousClick);
      // 
      // nextButton
      // 
      this.nextButton.Location = new System.Drawing.Point(12, 139);
      this.nextButton.Name = "nextButton";
      this.nextButton.Size = new System.Drawing.Size(63, 23);
      this.nextButton.TabIndex = 9;
      this.nextButton.Text = "Next";
      this.nextButton.UseVisualStyleBackColor = true;
      this.nextButton.Click += new System.EventHandler(this.nextClick);
      // 
      // firstButton
      // 
      this.firstButton.Location = new System.Drawing.Point(12, 110);
      this.firstButton.Name = "firstButton";
      this.firstButton.Size = new System.Drawing.Size(63, 23);
      this.firstButton.TabIndex = 10;
      this.firstButton.Text = "First";
      this.firstButton.UseVisualStyleBackColor = true;
      this.firstButton.Click += new System.EventHandler(this.firstButtonClick);
      // 
      // lastButton
      // 
      this.lastButton.Location = new System.Drawing.Point(81, 139);
      this.lastButton.Name = "lastButton";
      this.lastButton.Size = new System.Drawing.Size(63, 23);
      this.lastButton.TabIndex = 11;
      this.lastButton.Text = "Last";
      this.lastButton.UseVisualStyleBackColor = true;
      this.lastButton.Click += new System.EventHandler(this.lastButtonClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1021, 641);
      this.Controls.Add(this.lastButton);
      this.Controls.Add(this.firstButton);
      this.Controls.Add(this.nextButton);
      this.Controls.Add(this.previousButton);
      this.Controls.Add(this.resultList);
      this.Controls.Add(this.resultsCount);
      this.Controls.Add(this.resultLabel);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.searchTextLabel);
      this.Controls.Add(this.searchTextBox);
      this.Controls.Add(this.filePath);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "File Search";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label filePath;
    private System.Windows.Forms.TextBox searchTextBox;
    private System.Windows.Forms.Label searchTextLabel;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Label resultLabel;
    private System.Windows.Forms.Label resultsCount;
    private System.Windows.Forms.ListBox resultList;
    private System.Windows.Forms.Button previousButton;
    private System.Windows.Forms.Button nextButton;
    private System.Windows.Forms.Button firstButton;
    private System.Windows.Forms.Button lastButton;
  }
}

