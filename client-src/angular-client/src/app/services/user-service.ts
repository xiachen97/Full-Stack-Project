import { HttpClient, HttpHandler } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, map } from "rxjs";
import { IUser } from "../contracts/user.interface";
const USER_GET: string = 'api/users';
@Injectable() 
export class UserService {
    constructor(private http: HttpClient) { 
    }
    getUsers(): Observable<IUser[]> {
       return this.http.get<IUser[]>(USER_GET).pipe(
        map((res: any) => {
            return res;
        }));
    }

}