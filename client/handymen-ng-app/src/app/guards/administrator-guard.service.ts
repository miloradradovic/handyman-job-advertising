import {CanActivate, Router} from '@angular/router';
import {Injectable} from '@angular/core';
import {AuthService} from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AdministratorGuard implements CanActivate {

  constructor(
    public auth: AuthService,
    public router: Router
  ) { }

  canActivate(): boolean {
    const role = this.auth.getRole();
    if (role !== 'ADMINISTRATOR') {
      this.router.navigate(['/']);
      return false;
    }
    return true;
  }
}