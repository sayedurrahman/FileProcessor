using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessor
{
  public partial class FileProcessorForm : Form
  {
    public FileProcessorForm()
    {
        InitializeComponent();
        new Service.FileProcessorController("G:\\Delete2").UpdateCompanyName();
    }

  }
}
