Shader "Base/Hologram" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Alpha ("Alpha", Float) = 1
		_Frequency ("Frequency", Float) = 0
		_ScrollSpeed ("Scroll Speed", Float) = 0
		_LineIntensity ("Line Intensity", Float) = 1
		_Fresnel ("Fresnel", Float) = 1
		_FresnelIntensity ("Fresnel Intensity", Float) = 0
		_ScrollRotation ("Scroll Rotation", Float) = 0
		_FlashColor ("Flash Color", Vector) = (1,1,1,1)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}