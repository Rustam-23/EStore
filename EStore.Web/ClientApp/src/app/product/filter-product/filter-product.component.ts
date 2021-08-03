import {Component, Input, OnInit} from '@angular/core';
import {Specification, SpecificationTypeEnum} from "../../home/home.models";

@Component({
  selector: 'app-filter-product',
  templateUrl: './filter-product.component.html',
  styleUrls: ['./filter-product.component.css']
})
export class FilterProductComponent implements OnInit {
  @Input() specification: Specification;
  constructor() { }

  ngOnInit() {
  }

  checkStringType(): boolean {
    return this.specification.specificationType == SpecificationTypeEnum.SpecString;
  }
}
