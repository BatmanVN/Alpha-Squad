Shader "puzzle-hitman/GunBuilderPreview" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_RimColor ("Rim Color", Vector) = (1,1,1,1)
		_AnimSpeed ("SpeedMultiplier", Range(0, 5)) = 1
		_MinSize ("Min Rim Size", Float) = 0.5
		_MaxSize ("Max Rim Size", Float) = 4
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
}