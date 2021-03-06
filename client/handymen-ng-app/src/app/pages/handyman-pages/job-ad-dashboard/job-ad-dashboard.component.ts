import {Component, OnInit} from '@angular/core';
import {JobAdService} from '../../../services/job-ad.service';
import {MatSnackBar} from '@angular/material/snack-bar';
import {MatDialog} from '@angular/material/dialog';
import {CreateInterestDialogComponent} from '../../dialogs/create-interest-dialog/create-interest-dialog.component';
import {InterestService} from '../../../services/interest.service';
import {InterestModel} from '../../../model/interest.model';
import {Router} from '@angular/router';
import {NgxSpinnerService} from 'ngx-spinner';
import {PicturesDialogComponent} from '../../dialogs/pictures-dialog/pictures-dialog.component';

@Component({
  selector: 'app-job-ad-dashboard',
  templateUrl: './job-ad-dashboard.component.html',
  styleUrls: ['./job-ad-dashboard.component.css']
})
export class JobAdDashboardComponent implements OnInit {

  jobAds = [];

  constructor(
    public router: Router,
    private spinnerService: NgxSpinnerService,
    private jobAdService: JobAdService,
    private snackBar: MatSnackBar,
    public dialog: MatDialog,
    private interestService: InterestService
  ) {
  }

  ngOnInit(): void {
    this.getJobAdsForHandyman();
  }

  getJobAdsForHandyman(): void {
    this.jobAdService.getJobAdsByHandyman().subscribe(
      result => {
        this.jobAds = result.responseObject;
      }, error => {
        this.snackBar.open(error.error.message, 'Ok', {duration: 3000});
      }
    );
  }

  makeInterest($event: number): void {

    const dialogRef = this.dialog.open(CreateInterestDialogComponent, {
      width: '30%'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.spinnerService.show();
        const interest: InterestModel = new InterestModel(0, $event, result.days, result.price);
        this.interestService.createInterest(interest).subscribe(
          // tslint:disable-next-line:no-shadowed-variable
          result => {
            this.spinnerService.hide();
            this.snackBar.open(result.message, 'Ok', {duration: 3000});
            this.getJobAdsForHandyman();
          }, error => {
            this.spinnerService.hide();
            this.snackBar.open(error.error.message, 'Ok', {duration: 3000});
          }
        );
      }
    });

  }

  viewPics(pictures): void {
    const dialogRef = this.dialog.open(PicturesDialogComponent, {
      width: '80%',
      data: {pictures}
    });
  }
}
