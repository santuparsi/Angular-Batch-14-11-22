import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { User } from 'src/app/Models/user';
import { AccountService } from 'src/app/Services/account.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
    submitted = false;
user:User
    constructor(private formBuilder: FormBuilder,private accountService:AccountService,private router:Router) {
      this.user=new User();
     }

    ngOnInit() {
        this.registerForm = this.formBuilder.group({
            userid: ['', Validators.required],
            fname: ['', [Validators.required,
                Validators.pattern('^[a-zA-Z]{3,6}$')]],
            email: ['', [Validators.required,Validators.email]],
            mobile:['',[Validators.required,
                Validators.pattern("^[6-9][0-9]{9}$")]],
            password: ['', [Validators.required, Validators.minLength(6)]]
           
        });
    }

    // convenience getter for easy access to form fields
    get f() { return this.registerForm.controls; }

    onSubmit() {
     // alert('HHi')
        this.submitted = true;
        if (this.registerForm.valid) {
          this.user.userId=this.registerForm.value["userid"];
          this.user.name=this.registerForm.value["fname"];
          this.user.email=this.registerForm.value["email"];
          this.user.mobile=this.registerForm.value["mobile"]
          this.user.password=this.registerForm.value["password"];
          this.user.role="USER";
          console.log(this.user)
            this.accountService.Register(this.user).subscribe(response=>{

            })
            this.router.navigateByUrl('/login')

        }
    }

    onReset() {
        this.submitted = false;
        this.registerForm.reset();
    }
}
