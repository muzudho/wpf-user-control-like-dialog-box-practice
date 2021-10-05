namespace WpfUserControlLikeDialogBoxPractice.ViewModels
{
    using Livet;
    using Livet.Commands;

    internal class DialogBoxPageViewModel:ViewModel
    {
        private string _message="";

        /// <summary>
        /// 本文
        /// </summary>
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (_message == value)
                {
                    return;
                }
                _message = value;
                RaisePropertyChanged(nameof(Message));
            }
        }

        private ViewModelCommand? _okCommand;

        /// <summary>
        /// OKボタン押下時のコマンド
        /// </summary>
        public ViewModelCommand OkCommand
        {
            get
            {
                if (_okCommand == null)
                {
                    _okCommand = new ViewModelCommand(() => { });
                }
                return _okCommand;
            }
            set
            {
                if (_okCommand == value)
                {
                    return;
                }
                _okCommand = value;
                RaisePropertyChanged(nameof(OkCommand));
            }
        }
    }
}
