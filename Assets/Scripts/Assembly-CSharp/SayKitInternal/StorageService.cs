using System;

namespace SayKitInternal
{
	[Serializable]
	public class StorageService
	{
		private static readonly Lazy<StorageService> _lazyInstance;

		private StorageData _storageData;

		private readonly string _fileName;

		private FileSystemService _fileSystemService;

		public static StorageService Instance => null;

		public bool IsPremium
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RateAppPopupWasShowed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private StorageService()
		{
		}

		private void InitDataFromFile()
		{
		}

		public void Save()
		{
		}
	}
}
