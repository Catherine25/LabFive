using System.Windows.Forms;

namespace LabFive
{
    public partial class addDialog : Form
    {
        public Data _data;
        public bool _exists;

        public addDialog()
        {
            InitializeComponent();
            _okBt.Click += OkBt;
            if (_exists)
            {
                _subjectTb.Text = _data.Subject;
                _studentTb.Text = _data.Student;
                _markNumUD.Value = _data.Mark;
            }
        }

        private void OkBt(object sender, System.EventArgs e)
        {
            _data = new Data(_subjectTb.Text, _studentTb.Text, (int)_markNumUD.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
