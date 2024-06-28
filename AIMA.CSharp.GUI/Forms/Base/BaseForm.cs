namespace AIMA.CSharp.GUI.Forms.Base
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BaseForm : Form
    {

         /// <summary>
         /// 
         /// </summary>
        public CancellationTokenSource cancellationSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CancellationToken token { get; set; }
        /// <summary>
        /// 
        /// </summary>
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
