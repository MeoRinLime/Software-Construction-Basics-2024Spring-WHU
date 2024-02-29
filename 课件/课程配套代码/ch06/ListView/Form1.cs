using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    void PrepareImageList() {
      imageList1.ImageSize = new Size(32, 32);
      imageList1.Images.Add(
        Image.FromFile(@"c:\winnt\Gone Fishing.bmp"));
      imageList1.Images.Add(
        Image.FromFile(@"c:\winnt\Greenstone.bmp"));
      imageList1.Images.Add(
        Image.FromFile(@"c:\winnt\FeatherTexture.bmp"));
    }

    private void Form1_Load(object sender, System.EventArgs e) {
      PrepareImageList();
      CreateListView();
    }
  }
}
