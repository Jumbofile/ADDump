<#_____________________________________________________________
Active Directory Dump script
By:            Gregory Plachno
Based on:      Morgan Tech Space Script
Creation Date: 7/5/2017

***************************************************************
Requires Admin access and Active Directory module for Windows
Only tested on windows 10
______________________________________________________________#>

    #Import Active Directory and dump Computers info into a excel sheet
    Import-Module ActiveDirectory
    #Param($path)

    #User Properties that are going to be listed
    Get-ADComputer -Filter * -Properties * |
     Select -Property Name,Description |
     #Output file name and location
     Export-CSV "$path\ADCompDump.csv" -NoTypeInformation -Encoding UTF8

