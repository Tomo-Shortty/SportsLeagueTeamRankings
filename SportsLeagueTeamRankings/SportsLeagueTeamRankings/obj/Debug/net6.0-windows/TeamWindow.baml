   M S B A M L   `   `   `  ????S  OSportsLeagueTeamRankings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SportsLeagueTeamRankingsSportsLeagueTeamRankings  5   	   )    #SportsLeagueTeamRankings.TeamWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SportsLeagueTeamRankings     5   	     ? Title$  Teams??5   	   $	??400??6   $	??200??6$   .??5	      ? -   5         ?Name$ ViewTeamsBackgroundGrid??5	       ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $
??0.1* ?6   .+?5   
   ?? -   5         ??Name$ CancelTeamsButton??5      $??Cancel??6,   $
??Left=?6=   $??	130,0,0,0q?6X   $??1??6k   $??Center=?6x   $??60??6?    ?? IsCancel$
 True??6?   6?   ?? 5   
   -   5        $ SubmitTeamsButton??5      $??Submit??6,   $
??Left=?6=   $??65,0,0,0q?6X   $??1??6j   $??Center=?6w   $??60??6?    ?? 	IsDefault$
 True??6?   6?   ? 5   
   -   5        $ ViewTeamsGrid??5      5      5      