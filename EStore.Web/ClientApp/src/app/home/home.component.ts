import { Component } from '@angular/core';
import {Observable} from "rxjs";
import {Category} from "./home.models";
import {HomeService} from "./home.service";
import {Product} from "../product/product.models";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  categories$: Observable<Category[]>

  search = '';

  constructor(private homeService: HomeService) {
    this.categories$ = homeService.getAllCategories();
  }
}
