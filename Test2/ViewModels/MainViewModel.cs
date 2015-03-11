using System;
using GalaSoft.MvvmLight;

namespace Test2
{
	public class MainViewModel : ViewModelBase
	{
		public MainViewModel ()
		{
		}

		private Boolean pLifeList;
		public Boolean LifeList {
			get { return pLifeList; }

			set {
				if (value != pLifeList) {
					pLifeList = value;
					RaisePropertyChanged(() => LifeList);
				}
			}
		}

		private Boolean pSeenInThisState;
		public Boolean SeenInThisState {
			get { return pSeenInThisState; }

			set {
				if (value != pSeenInThisState) {
					pSeenInThisState = value;
					RaisePropertyChanged(() => SeenInThisState);
				}
			}
		}

		private Boolean pSeenInThisList;
		public Boolean SeenInThisList {
			get { return pSeenInThisList; }

			set {
				if (value != pSeenInThisList) {
					pSeenInThisList = value;
					RaisePropertyChanged(() => SeenInThisList);
				}
			}
		}
	}
}

