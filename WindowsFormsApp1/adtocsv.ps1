<#_____________________________________________________________
Active Directory Dump script
By:            Gregory Plachno
Based on:      Morgan Tech Space Script
Creation Date: 7/5/2017

***************************************************************
Requires Admin access and Active Directory module for Windows
Only tested on windows 10
______________________________________________________________#>

    #Import Active Directory and dump User info into a excel sheet
    Import-Module ActiveDirectory

    #User Properties that are going to be listed
    Get-ADUser -Filter * -Properties * |
     Select -Property Name,Mail,Department,Description,Office |
     #Output file name and location
     Export-CSV "$path\ADDump.csv" -NoTypeInformation -Encoding UTF8

    Write-Host -NoNewline "DEBUG."
