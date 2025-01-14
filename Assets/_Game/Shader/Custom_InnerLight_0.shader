Shader "Custom/InnerLight" {
	Properties {
		_OuterColor ("OuterColor", Vector) = (1,1,1,1)
		_InnerColor ("CenterColor", Vector) = (1,1,1,1)
		_LightThreshold ("Rim Threshold", Float) = 1
		_IntensityMultiplier ("Intensity Multiplier", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
}