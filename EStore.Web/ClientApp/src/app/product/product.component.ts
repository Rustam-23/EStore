import {Component, Input, OnInit} from '@angular/core';
import {Product} from "./product.models";
import {Observable} from "rxjs";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  @Input() product: Product;

  product$: Observable<Product>;

  constructor() { }

  ngOnInit() {
  }

}
