using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class AttackRangeCircle : MonoBehaviour
{
    public float radius = 5f; 
    public int segments = 100;
    [SerializeField] private LineRenderer lineRenderer;
    public LayerMask enemyLayer;
    private void OnValidate()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        SetupAttackRanger();
        InvokeRepeating(nameof(CheckEnemiesInRange), 0f, 0.5f);

    }

    private void SetupAttackRanger(){
        gameObject.SetActive(true);

        lineRenderer.positionCount = segments + 1;
        lineRenderer.useWorldSpace = false;
        lineRenderer.loop = true;

        DrawCircle();
    }

    void DrawCircle()
    {
        float angleStep = 360f / segments;
        for (int i = 0; i <= segments; i++)
        {
            float angle = Mathf.Deg2Rad * i * angleStep;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius; // Chuyển từ Y -> Z để dựng đứng
            lineRenderer.SetPosition(i, new Vector3(x, z, 0)); // Xoay vòng tròn theo trục X
        }
    }

    private void CheckEnemiesInRange()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius, enemyLayer);
        foreach (var enemy in hitColliders)
        {
            Debug.Log("Kẻ địch trong tầm bắn: " + enemy.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
