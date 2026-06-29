using UnityEngine;

[CreateAssetMenu(fileName = "NewSubjectData", menuName = "Data/Subject Data")]
public class SubjectData : ScriptableObject
{
    [Header("Subject Info")]
    public string subjectName = "Mathematics";

    [Header("Academic Details")]
    public int creditHours = 3;
    public float passingGrade = 60.0f;

    [Header("Enrollment")]
    public bool isMandatory = true;
    public int enrolledStudents = 45;
}