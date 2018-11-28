using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabFive
{
    public partial class MainForm : Form
    {
        //data
        private BindingSource _bs;
        bool _isSerialized;

        public MainForm()
        {
            InitializeComponent();
            _sortBySubjectBt.Click += SortBySubjectBt;
            _sortByNameBt.Click += SortByNameBt;
            _filterCb.Click += FilterCb;
            _addBt.Click += AddBt;
            _deleteBt.Click += (sender, args) => _bs.RemoveCurrent();
            _saveBt.Click += SaveBt;
            _loadBt.Click += LoadBt;

            _bs = new BindingSource { DataSource = DataController._dataToShow };

            mainTable.DataSource = _bs;
        }

        private void LoadBt(object sender, EventArgs e) => Deserialize();

        private void SaveBt(object sender, EventArgs e) => Serialize();

        //UI
        private void AddBt(object sender, EventArgs e)
        {
            var dialog = new addDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mainTable.DataSource = _bs;
                _bs.Add(dialog._data);
            }
        }

        private void FilterCb(object sender, EventArgs e)
        {
            var filter = from d in DataController._dataToShow
                         where d.Subject.Equals(_filterCb.Text)
                         select d;
            _bs.DataSource = filter;
        }

        private void SortByNameBt(object sender, EventArgs e)
        {
            var sort = from d in DataController._dataToShow
                           orderby d.Student
                           select d;
            _bs.DataSource = sort;
        }

        private void SortBySubjectBt(object sender, EventArgs e)
        {
            var sort = from d in DataController._dataToShow
                       orderby d.Subject
                       select d;
            _bs.DataSource = sort;
        }

        private void Serialize()
        {
            _isSerialized = true;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, _bs.DataSource);
            }
        }

        private void Deserialize()
        {
            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                if (_isSerialized)
                {
                    var deserilizeData = (List<Data>)new BinaryFormatter().Deserialize(fs);

                    _bs.DataSource = deserilizeData;
                }
            }
        }
    }
}
