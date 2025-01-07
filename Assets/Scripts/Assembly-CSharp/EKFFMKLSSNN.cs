public interface EKFFMKLSSNN
{
	MinibossConfig GetMinibossConfig();

	bool ShouldStageHaveMiniboss();

	WorldData.JQNPLTQOFMJ GetWorldType();

	int GetWorldVariation();

	int GetNumStages();

	float GetDensity(int MTFHQPOPFKQ);

	EnemyCount GetEnemyCount(int MTFHQPOPFKQ);

	int GetEnemyLevel(int MTFHQPOPFKQ);

	bool IsEnemyEliteAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE);

	int GenerateNewStageId(int MTFHQPOPFKQ);

	uint GetSeed(int MTFHQPOPFKQ);

	bool IsEnemyTypeAllowed(EnemySpot.SMMGLQPTJET EOOEIROQJOE);

	float GetEliteChance(int MTFHQPOPFKQ);

	int GetEliteLevelAdd(int MTFHQPOPFKQ);

	string GetAnalyticsContext();
}
