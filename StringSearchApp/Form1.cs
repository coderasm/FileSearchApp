using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StringSearchApp
{
  public partial class Form1 : Form
  {
    private string[] fileLines;
    private int highlightIndex = 0;
    private OpenFileDialog fileDialog = new OpenFileDialog();
    public Form1()
    {
      InitializeComponent();
      fileDialog.Multiselect = false;
    }

    private void loadButtonClicked(object sender, EventArgs e)
    {
      //prompt for file
      if (fileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          filePath.Text = fileDialog.FileName;
          //read file
          var sr = new StreamReader(fileDialog.FileName);
          //split file by lines
          fileLines = sr.ReadToEnd().Split('\n');
        }
        catch (SecurityException ex)
        {
          MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
          $"Details:\n\n{ex.StackTrace}");
        }
      }
    }

    private void searchButtonClicked(object sender, EventArgs e)
    {
      //only search if there is search text and a file is loaded
      if (searchTextBox.Text != "" && fileLines.Length > 0)
      {
        resultList.Items.Clear();
        //search only for whole words
        var regex = new Regex($@"(?:^|\s)([^\s]*{searchTextBox.Text}[^\s]*)(?:\s|$)", RegexOptions.IgnoreCase);
        for (int i = 0; i < fileLines.Length; i++)
        {
          var matches = regex.Matches(fileLines[i]);
          if (matches.Count > 0)
          {
            foreach (var match in matches)
            {
              var entry = $"Line {i + 1}: Word: \"{match.ToString().Trim()}\", sentence: {fileLines[i]}";
              resultList.Items.Add(entry);
            }
          }
        }
        resultsCount.Text = resultList.Items.Count.ToString();
        resultList.SetSelected(0, true);
      }
    }

    private void previousClick(object sender, EventArgs e)
    {
      if (resultList.Items.Count > 0)
      {
        resultList.SetSelected(highlightIndex, false);
        if (highlightIndex == 0)
          highlightIndex = resultList.Items.Count - 1;
        else
          --highlightIndex;
        resultList.SetSelected(highlightIndex, true);
      }
    }

    private void nextClick(object sender, EventArgs e)
    {
      if (resultList.Items.Count > 0)
      {
        resultList.SetSelected(highlightIndex, false);
        if (highlightIndex == resultList.Items.Count - 1)
          highlightIndex = 0;
        else
          ++highlightIndex;
        resultList.SetSelected(highlightIndex, true);
      }
    }

    private void firstButtonClick(object sender, EventArgs e)
    {
      if (resultList.Items.Count > 0)
      {
        resultList.SetSelected(highlightIndex, false);
        highlightIndex = 0;
        resultList.SetSelected(highlightIndex, true);
      }
    }

    private void lastButtonClick(object sender, EventArgs e)
    {
      if (resultList.Items.Count > 0)
      {
        resultList.SetSelected(highlightIndex, false);
        highlightIndex = resultList.Items.Count - 1;
        resultList.SetSelected(highlightIndex, true);
      }
    }
  }
}
