using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillSelect : MonoBehaviour
{
    [SerializeField]
    public GameObject[] skills;

    public int maxLevelNum;
    public void RandomShow()
    {
        for (int i = 0; i < skills.Length; i++)
        {
            skills[i].SetActive(false);
        }
        int[] ran = new int[3];
        HashSet<int> usedIndices = new HashSet<int>(); // 이미 사용한 인덱스를 저장하는 HashSet

        for (int i = 0; i < ran.Length; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = UnityEngine.Random.Range(0, skills.Length); // 난수 생성
            }
            while (usedIndices.Contains(randomIndex)); // 이미 사용한 인덱스라면 다시 생성

            ran[i] = randomIndex; // 난수를 배열에 할당
            usedIndices.Add(randomIndex); // 사용한 인덱스로 표시
        }

        for (int i = 0; i < ran.Length; i++)
        {
            skills[ran[i]].SetActive(true);
        }
    }

    // 스킬 선택시 스킬 획득OR레벨업
    public void OnClickSkill(GameObject skill)
    {
        Define.Skills weaponName = (Define.Skills)Enum.Parse(typeof(Define.Skills), skill.name);
        int _level = skill.transform.GetChild(2).GetComponent<TMP_Text>().text[3] - '0';
        string temp = skill.transform.GetChild(2).GetComponent<TMP_Text>().text;
        _level++;

        skill.transform.GetChild(2).GetComponent<TMP_Text>().text = temp.Substring(0, 3) + _level;
        GameManager.Instance.GetOrSetSkill(weaponName);
        GameManager.Instance.Resume();
        gameObject.SetActive(false);
    }
}
