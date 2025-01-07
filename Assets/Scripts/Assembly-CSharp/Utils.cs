using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MersenneTwister;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public static class Utils
{
	public class AccumulativeList<T> where T : IComparable
	{
		private List<(T, int)> list;

		public void TryAdd(T type, int amount)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class IntervaledLogic
	{
		private bool initialised;

		private int resetInterval;

		private int resetIntervalShort;

		private int totalActivationCount;

		private int startTime;

		private bool globalReset;

		private Action Save;

		[JsonProperty]
		private int activationCount;

		[JsonProperty]
		private int lastResetTime;

		[JsonProperty]
		private int globalResetTime;

		public void Setup(int _resetInterval, int _resetIntervalShort, int _totalActivationCount, int _startTime, bool _globalReset, Action _save)
		{
		}

		public bool IsSetup()
		{
			return false;
		}

		public void Activate()
		{
		}

		public bool CanActivate()
		{
			return false;
		}

		private void TestReset()
		{
		}

		public int GetTimeRemainingNextReset()
		{
			return 0;
		}

		public int GetActivationsRemaining()
		{
			return 0;
		}

		public bool IsAtMaxActivations()
		{
			return false;
		}

		private int GetResetTimeRemainingShort()
		{
			return 0;
		}

		private int GetResetTimeRemainingLong()
		{
			return 0;
		}

		private void ResetActivations()
		{
		}
	}

	public class JsonWrap<T>
	{
		public T[] array;

		private JsonWrap()
		{
		}

		public static T[] FromJson(string json, string defaultValue = null)
		{
			return null;
		}
	}

	public class JsonWrap2<T>
	{
		private class Intermediate
		{
			public string[] array;

			public string GetParsed()
			{
				return null;
			}

			public void ReParse()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public T[][] array;

		private JsonWrap2()
		{
		}

		public static T[][] FromJson(string json, string defaultValue = null)
		{
			return null;
		}
	}

	public class Timer
	{
		public float interval;

		private float time;

		public event Action call
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Run()
		{
		}

		public void Reset()
		{
		}
	}

	public class ReadOnlyAttribute : PropertyAttribute
	{
	}

	public static class LevenshteinDistance
	{
		public static int Compute(string s, string t)
		{
			return 0;
		}
	}

	public static Tween ScrollToRectTransformVerticalWithAnimation(this ScrollRect scroll, RectTransform rt, float t)
	{
		return null;
	}

	public static void ScrollToRectTransformVertical(this ScrollRect scroll, RectTransform rt)
	{
	}

	public static void ScrollToContentPos(this ScrollRect scroll, Vector3 p)
	{
	}

	public static void ScrollToRectTransformHorizontal(this ScrollRectEx scroll, RectTransform rt)
	{
	}

	public static uint GenerateSeedFromList(List<int> list)
	{
		return 0u;
	}

	public static T WeightedRandom<T>(List<int> weights, List<T> outcomes)
	{
		return default(T);
	}

	public static int WeightedRandomIndex(int[] weights)
	{
		return 0;
	}

	public static T WeightedRandom<T>(List<int> weights, List<T> outcomes, System.Random customRandom)
	{
		return default(T);
	}

	public static T WeightedRandom<T>(int[] weights, T[] outcomes, System.Random customRandom = null)
	{
		return default(T);
	}

	public static T WeightedRandom<T>(List<int> weights, List<T> outcomes, MTRandom mt)
	{
		return default(T);
	}

	public static string GetNumberExpression(int number, string format = "0.0", bool hideZero = false)
	{
		return null;
	}

	public static string GetNumberExpression(long number, bool roundDown = false)
	{
		return null;
	}

	public static string GetNumberDollar(long number)
	{
		return null;
	}

	public static void SetEditorGameObjectDirty(GameObject gameObject)
	{
	}

	public static void SetEditorCurrentPrefabSceneDirty()
	{
	}

	public static Color StringToColor(string color)
	{
		return default(Color);
	}

	public static bool ExecuteEvery(float interval, ref float timer)
	{
		return false;
	}

	public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		intersection = default(Vector3);
		return false;
	}

	public static Vector2 RayCircleIntersection(Vector2 circlePos, float radius, Vector2 rayPos, Vector2 rayDir)
	{
		return default(Vector2);
	}

	public static Vector3 LerpVec3(Vector3 a, Vector3 b, float w)
	{
		return default(Vector3);
	}

	public static T WeightedRandom<T>(T[] values, float[] chances)
	{
		return default(T);
	}

	public static int RandomRange(MTRandom mt, int min, int max)
	{
		return 0;
	}

	public static float RandomExclusive(MTRandom mt)
	{
		return 0f;
	}

	public static float RandomRange(MTRandom mt, float min, float max)
	{
		return 0f;
	}

	public static bool IntervalTimeStep(float timeLast, float delta, float interval)
	{
		return false;
	}

	public static int GetTimestamp()
	{
		return 0;
	}

	public static int CalculateNumberOfTicksSince(int from, int duration, int offset = 0)
	{
		return 0;
	}

	public static long CalculateNumberOfTicksSince(long from, long duration, long offset = 0L)
	{
		return 0L;
	}

	public static int GetTimestampOffline()
	{
		return 0;
	}

	public static int DateTimeToTimestamp(DateTime dt)
	{
		return 0;
	}

	public static DateTime TimestampToDateTime(int timestamp)
	{
		return default(DateTime);
	}

	public static DateTime GetEpochStart()
	{
		return default(DateTime);
	}

	public static string GetTimeAgoString(DateTime absoluteTime)
	{
		return null;
	}

	public static string GetTimeToString(DateTime absoluteTime, bool showMinutes = false)
	{
		return null;
	}

	public static string GetTimeToString(int delta, bool showMinutes = false)
	{
		return null;
	}

	public static int Sum(int i, int n, Func<int, int, int> f)
	{
		return 0;
	}

	public static Quaternion GetRotationBetween(Vector3 a, Vector3 b)
	{
		return default(Quaternion);
	}

	public static Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angles)
	{
		return default(Vector3);
	}

	public static Vector3 SmoothDampVec3(Vector3 start, Vector3 goal, ref Vector3 velocity, float time)
	{
		return default(Vector3);
	}

	public static Vector3 SmoothDampVec3Angle(Vector3 start, Vector3 goal, ref Vector3 velocity, float time)
	{
		return default(Vector3);
	}

	public static Color RandomColor(Color min, Color max)
	{
		return default(Color);
	}

	public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	public static void LogEnumerable(IEnumerable collection)
	{
	}

	public static void IterateOverEnum<T>(Action<T> action) where T : Enum
	{
	}

	public static void LogEnumerable(string message, IEnumerable collection)
	{
	}

	public static string StringEnumerable(string message, IEnumerable collection)
	{
		return null;
	}

	public static void ChangeGameObjectLayer(GameObject go, int to, bool recursive = true)
	{
	}

	public static void FitGameObjectToRectTransform(GameObject go, GameObject original, RectTransform fitRect, Transform scalingParent, out Bounds calculatedBounds, bool positionToBoundsCenter = true, float relativeScale = 0.6f, bool worldSpaceMeshBounds = true)
	{
		calculatedBounds = default(Bounds);
	}

	public static void RebuildLayout(RectTransform rect, bool testHorzVert = false)
	{
	}

	public static int StepValue(int value, int step)
	{
		return 0;
	}

	public static float StepValue(float value, float step, int precision = 3)
	{
		return 0f;
	}

	public static string GetMinMaxString(int min, int max)
	{
		return null;
	}

	public static string RandomString(int length)
	{
		return null;
	}

	public static Tween DOTextWithNumber(this Text self, float start, float end, float t, Action<float> action)
	{
		return null;
	}

	public static Tween DOSpeed(this Animator self, float toSpeed, float t)
	{
		return null;
	}

	public static int NonAllocUniques<T, D>(List<T> initial, D[] uniques, Func<T, D[], bool> comp, Func<T, D> adder)
	{
		return 0;
	}

	public static Tween DOTimeDynamic(TimeSpan timeStart, Func<TimeSpan> getTimeFunction, Action<TimeSpan> updateFun, float t)
	{
		return null;
	}

	public static TimeSpan LerpTimeSpan(TimeSpan from, TimeSpan to, float t)
	{
		return default(TimeSpan);
	}

	public static bool TestResetTimestampSequential(ref int timestamp, int interval, int currentTime = -1, bool force = false)
	{
		return false;
	}

	public static bool TestResetTimestampInstant(ref int timestamp, int interval, int currentTime = -1)
	{
		return false;
	}

	public static List<T> GetEnumList<T>() where T : struct, IConvertible
	{
		return null;
	}

	public static GameObject InstantiateAsPrefab(GameObject prefab, Transform parent = null)
	{
		return null;
	}

	public static void ExecuteAtFrameEnd(this MonoBehaviour me, Action funk)
	{
	}

	public static bool IsUIactive()
	{
		return false;
	}

	public static float NormalizeAngle(float a)
	{
		return 0f;
	}

	public static bool CreateFakeDiscountPrice(string priceString, string isoCurrency, decimal discount, out string discountedPriceString, bool roundToClosest = false)
	{
		discountedPriceString = null;
		return false;
	}

	public static Shadow GetComponentShadow(this GameObject go)
	{
		return null;
	}

	public static string ToRoman(int number)
	{
		return null;
	}

	public static string SplitCamelCase(this string str)
	{
		return null;
	}

	public static int GetIntForString(string str)
	{
		return 0;
	}

	public static void RefreshContentFitters(RectTransform transform)
	{
	}

	public static string GetGoogleDriveDirectUrl(string url)
	{
		return null;
	}
}
