
using UnityEngine;


using System.Collections;


public class BanReportAndBan : MonoBehaviour


{


// Change this variable to be the number of reports required for a ban. Right now its 20.


public int num_reports = 20;


void Update()


{
// If the current number of reports reaches the amount required for a ban, a ban should activate.

