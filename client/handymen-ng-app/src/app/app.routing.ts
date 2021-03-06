import {AppComponent} from './app.component';
import {RouterModule, Routes} from '@angular/router';
import {CommonModule} from '@angular/common';
import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {LoginComponent} from './pages/login/login.component';
import {RegisterUserComponent} from './pages/registration/register-user/register-user.component';
import {RegisterHandymanComponent} from './pages/registration/register-handyman/register-handyman.component';
import {HandymenDashboardComponent} from './pages/user-pages/handymen-dashboard-browse/handymen-dashboard.component';
import {LogInGuard} from './guards/log-in-guard.service';
import {UserGuard} from './guards/user-guard.service';
import {HandymanGuard} from './guards/handyman-guard.service';
import {AdministratorGuard} from './guards/administrator-guard.service';
import {CreateJobadFormComponent} from './pages/user-pages/create-jobad-form/create-jobad-form.component';
import {JobadDashboardComponent} from './pages/user-pages/jobad-dashboard/jobad-dashboard.component';
import {JobAdDashboardComponent} from './pages/handyman-pages/job-ad-dashboard/job-ad-dashboard.component';
import {InterestsDashboardComponent} from './pages/user-pages/interests-dashboard/interests-dashboard.component';
import {JobsDashboardComponent} from './pages/user-pages/jobs-dashboard/jobs-dashboard.component';
import {JobDashboardComponent} from './pages/handyman-pages/job-dashboard/job-dashboard.component';
import {OfferDashboardComponent} from './pages/handyman-pages/offer-dashboard/offer-dashboard.component';
import {HandymanProfileComponent} from './pages/handyman-pages/handyman-profile/handyman-profile.component';
import {UserProfileComponent} from './pages/user-pages/user-profile/user-profile.component';
import {RegistrationRequestsDashboardComponent} from './pages/admin-pages/registration-requests-dashboard/registration-requests-dashboard.component';
import {AllHandymenDashboardComponent} from './pages/user-pages/all-handymen-dashboard/all-handymen-dashboard.component';
import {RatingRequestsDashboardComponent} from './pages/admin-pages/rating-requests-dashboard/rating-requests-dashboard.component';

const routes: Routes = [

  {
    path: '',
    component: LoginComponent,
    canActivate: [LogInGuard]
  },
  {
    path: 'user',
    children: [
      {
        path: 'register',
        component: RegisterUserComponent,
        canActivate: [LogInGuard]
      },
      {
        path: 'handymen-dashboard-browse',
        component: HandymenDashboardComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'jobad-create',
        component: CreateJobadFormComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'jobad-dashboard',
        component: JobadDashboardComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'interests-dashboard',
        component: InterestsDashboardComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'jobs-dashboard',
        component: JobsDashboardComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'profile',
        component: UserProfileComponent,
        canActivate: [UserGuard]
      },
      {
        path: 'all-handymen',
        component: AllHandymenDashboardComponent,
        canActivate: [UserGuard]
      }
    ]
  },
  {
    path: 'handyman',
    children: [
      {
        path: 'register',
        component: RegisterHandymanComponent,
        canActivate: [LogInGuard]
      },
      {
        path: 'jobad-dashboard',
        component: JobAdDashboardComponent,
        canActivate: [HandymanGuard]
      },
      {
        path: 'jobs-dashboard',
        component: JobDashboardComponent,
        canActivate: [HandymanGuard]
      },
      {
        path: 'offers-dashboard',
        component: OfferDashboardComponent,
        canActivate: [HandymanGuard]
      },
      {
        path: 'profile',
        component: HandymanProfileComponent,
        canActivate: [HandymanGuard]
      }
    ]
  },
  {
    path: 'admin',
    children: [
      {
        path: 'registration-requests',
        component: RegistrationRequestsDashboardComponent,
        canActivate: [AdministratorGuard]
      },
      {
        path: 'rating-requests',
        component: RatingRequestsDashboardComponent,
        canActivate: [AdministratorGuard]
      }
    ]
  }
];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ],
})
export class AppRoutingModule { }
