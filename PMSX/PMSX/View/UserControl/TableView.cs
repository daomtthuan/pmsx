using DevExpress.XtraEditors;
using System;

namespace PMSX.View.UserControl {
    public abstract partial class TableView : XtraUserControl {
        public TableView() {
            InitializeComponent();
            Init();
        }

        protected abstract void Init();

        protected abstract void View_Load(object sender, EventArgs e);

        protected abstract void InsertButton_Click(object sender, EventArgs e);

        protected abstract void UpdateButton_Click(object sender, EventArgs e);


        protected abstract void DeleteButton_Click(object sender, EventArgs e);
    }
}
