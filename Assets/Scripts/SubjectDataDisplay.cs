using UnityEngine;
using TMPro;

public class SubjectDataDisplay : MonoBehaviour
{
    [Header("Scriptable Object Reference")]
    public SubjectData  subjectData;

    [Header("UI Text References")]
    public TMP_Text subjectNameText;
    public TMP_Text creditHoursText;
    public TMP_Text passingGradeText;
    public TMP_Text isMandatoryText;
    public TMP_Text enrolledStudentsText;

    void Start()
    {
        DisplayData();
    }

    public void DisplayData()
    {
        if (subjectData == null)
        {
            Debug.LogWarning("No SubjectData asset assigned!");
            return;
        }

        subjectNameText.text      = "Subject: "    + subjectData.subjectName;
        creditHoursText.text      = "Credits: "    + subjectData.creditHours.ToString();
        passingGradeText.text     = "Pass Grade: " + subjectData.passingGrade.ToString("F1");
        isMandatoryText.text      = "Mandatory: "  + subjectData.isMandatory.ToString();
        enrolledStudentsText.text = "Students: "   + subjectData.enrolledStudents.ToString();
    }
}