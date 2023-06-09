import { Injectable } from '@angular/core';
import {
  Router, Resolve,
  RouterStateSnapshot,
  ActivatedRouteSnapshot
} from '@angular/router';
import { Observable, of } from 'rxjs';
import { MembersService } from '../_services/members.service';
import { Member } from '../_models/Member';

@Injectable({
  providedIn: 'root'
})
export class MemberDetailedResolver implements Resolve<Member> {
  constructor(private memberSerive: MembersService) {}

  resolve(route: ActivatedRouteSnapshot): Observable<Member> {
    return this.memberSerive.getMember(route.paramMap.get('username')!)
  }
}
