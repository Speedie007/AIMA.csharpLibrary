namespace AIMA.CSharp.GUI.Forms.Base
{
    public partial class BaseForm : Form
    {

         
        public CancellationTokenSource cancellationSource { get; set; }

        public CancellationToken token { get; set; }
        
        public BaseForm()
        {
            InitializeComponent();
            cancellationSource = new CancellationTokenSource();
        }



        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTestBtn_Click(object sender, EventArgs e)
        {

           
        }
    }
}
