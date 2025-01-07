using System;
using UnityEngine.Purchasing;

namespace SayKitInternal
{
	public class InAppManager
	{
		private Action<InAppProduct> _validationCallback;

		private Product _purchasedProduct;

		private InAppRequestData _requestData;

		public static InAppManager Instance { get; }

		public void TrackPurchase(PurchaseEventArgs purchaseEventArgs, Action<InAppProduct> validationCallback, string offer, string placement)
		{
		}

		public void TrackPurchase(Product purchasedProduct, Action<InAppProduct> validationCallback, string offer, string placement)
		{
		}

		private void CheckInApp(InAppRequestData requestData, Product purchasedProduct, Action<InAppProduct> validationCallback)
		{
		}

		public void OnInAppProductChecked(string json)
		{
		}

		private void CallErrorValidationCallBack(string errorMessage, string stackTrace, InAppProduct product, Action<InAppProduct> validationCallback, bool trackException = true)
		{
		}
	}
}
