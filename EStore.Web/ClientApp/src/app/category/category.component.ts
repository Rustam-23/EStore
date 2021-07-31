import {Component, Input, OnInit} from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {HomeService} from "../home/home.service";
import {Observable} from "rxjs";
import {Product} from "../product/product.models";
import {Specification} from "../home/home.models";

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  products$: Observable<Product[]>;
  specification$: Observable<Specification[]>;

  constructor(private route: ActivatedRoute,
              private homeService: HomeService) { }

  ngOnInit() {
    this.getAllSpecificationByCategory();
    this.getAllProductsByCategoryId();
  }
  getAllProductsByCategoryId(): void {
    const id = parseInt(this.route.snapshot.paramMap.get('id')!, 10);
    this.products$=this.homeService.getAllProductsByCategoryId(id);
  }
  getAllSpecificationByCategory(): void {
    const id = parseInt(this.route.snapshot.paramMap.get('id')!, 10);
    this.specification$=this.homeService.getAllSpecificationByCategory(id);
  }
}
