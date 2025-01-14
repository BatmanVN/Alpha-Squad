Shader "puzzle-hitman/LightGradientSurfGlobalTX_VertexDisplace_Relative" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		_SpecularColor ("Specular Color", Vector) = (1,1,1,1)
		_ShadowStrength ("Shadow Strength", Range(0, 1)) = 0
		_Shininess ("Glossiness", Float) = 1
		_Reflectiveness ("Reflectiveness", Range(0, 1)) = 1
		_RimLight ("Rim Light Strength", Range(0, 1)) = 0
		_RimLightSZ ("Rim Light Size", Range(0, 1)) = 0
		_BlikGradient ("Blik Gradient", 2D) = "black" {}
		[Space] _DamageBlinkColor ("Damage blink color", Vector) = (1,1,1,1)
		_DamageBlinkRatio ("Damage blink ratio", Range(0, 1)) = 0
		_LightenEnable ("Enable Y Lightening", Float) = 0
		_OffsetTexture ("Offset Texture", 2D) = "white" {}
		_OffsetAmplitude ("Amplitude", Float) = 1
		_SpeedX ("Speed X", Float) = 1
		_SpeedY ("Speed Y", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "CustomLight/PhongSimplified"
}