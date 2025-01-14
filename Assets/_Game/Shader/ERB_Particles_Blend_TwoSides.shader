Shader "ERB/Particles/Blend_TwoSides" {
	Properties {
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_MainTex ("Main Tex", 2D) = "white" {}
		_Mask ("Mask", 2D) = "white" {}
		_Noise ("Noise", 2D) = "white" {}
		_SpeedMainTexUVNoiseZW ("Speed MainTex U/V + Noise Z/W", Vector) = (0,0,0,0)
		_FrontFacesColor ("Front Faces Color", Vector) = (0,0.2313726,1,1)
		_BackFacesColor ("Back Faces Color", Vector) = (0.1098039,0.4235294,1,1)
		_Emission ("Emission", Float) = 2
		[Toggle] _UseFresnel ("Use Fresnel?", Float) = 1
		[Toggle] _SeparateFresnel ("SeparateFresnel", Float) = 0
		_SeparateEmission ("Separate Emission", Float) = 2
		_FresnelColor ("Fresnel Color", Vector) = (1,1,1,1)
		_Fresnel ("Fresnel", Float) = 1
		_FresnelEmission ("Fresnel Emission", Float) = 1
		[Toggle] _UseCustomData ("Use Custom Data?", Float) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] _tex4coord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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