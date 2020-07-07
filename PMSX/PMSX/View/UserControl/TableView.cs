using DevExpress.XtraEditors;
using System;

namespace PMSX.View.UserControl {
    public abstract partial class TableView : XtraUserControl {
        public TableView() {
            InitializeComponent();
            OnInit();
        }

        protected abstract void OnInit();

        protected abstract void OnLoad();

        protected abstract void OnInsert();

        protected abstract void OnUpdate();

        protected abstract void OnDelete();

        private void View_Load(object sender, EventArgs e) {
            OnLoad();
        }

        private void InsertButton_Click(object sender, EventArgs e) {
            OnInsert();
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            OnUpdate();
        }


        private void DeleteButton_Click(object sender, EventArgs e) {
            OnDelete();
        }
    }
}
