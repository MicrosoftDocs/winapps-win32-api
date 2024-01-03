---
UID: NS:dwrite_3.DWRITE_PAINT_ELEMENT
tech.root: dwritecore
title: DWRITE_PAINT_ELEMENT
ms.date: 
targetos: Windows
description: 
prerelease: false
req.construct-type: structure
req.ddi-compliance: 
req.dll: 
req.header: dwrite_3.h
req.include-header: 
req.kmdf-ver: 
req.lib: 
req.max-support: 
req.redist: 
req.target-min-winverclnt: Windows 10, version 1809 (with Windows App SDK 1.2 or later)
req.target-min-winversvr: 
req.target-type: 
req.typenames: 
req.umdf-ver: 
req.unicode-ansi: 
topic_type:
 - apiref
api_type:
 - HeaderDef
api_location:
 - dwrite_3.h
api_name:
 - DWRITE_PAINT_ELEMENT
f1_keywords:
 - DWRITE_PAINT_ELEMENT
 - dwrite_3/DWRITE_PAINT_ELEMENT
dev_langs:
 - c++
helpviewer_keywords:
 - DWRITE_PAINT_ELEMENT
---

## -description

### DWRITE_PAINT_ELEMENT Structure

Specifies properties of a paint element, which is one node in a visual tree associated with a color glyph. This is passed as an output parameter to various [IDWritePaintReader](./nn-dwrite_3-idwritepaintreader.md) methods.

For a detailed description of how paint elements should be rendered, see the OpenType COLR table specification. Some of the descriptions in this topic reference the COLR paint record formats associated with each paint type.

## -struct-fields

### -field paintType

Type: **[DWRITE_PAINT_TYPE](./ne-dwrite_3-dwrite_paint_type.md)**

Specifies the paint type, and thus which member of the union is valid.

### -field PAINT_UNION

Specifies type-specific properties of the paint element.

### -field PAINT_UNION.PAINT_LAYERS

Valid for paint elements of type [DWRITE_PAINT_TYPE_LAYERS](./ne-dwrite_3-dwrite_paint_type.md). Contains one or more child paint elements to be drawn in bottom-up order.

This corresponds to a *PaintColrLayers* record in the OpenType COLR table. Or it might correspond to a *BaseGlyph* record defined by COLR version 0.

### -field PAINT_UNION.PAINT_LAYERS.childCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of child paint elements in bottom-up order. Use [IDWritePaintReader::MoveToFirstChild](./nf-dwrite_3-idwritepaintreader-movetofirstchild.md) and [MoveToNextSibling](./nf-dwrite_3-idwritepaintreader-movetonextsibling.md) to retrieve the child paint elements. Use the [MoveToParent](./nf-dwrite_3-idwritepaintreader-movetoparent.md) method to return to the parent element.

### -field PAINT_UNION.layers

Type: **[PAINT_UNION.PAINT_LAYERS](#field-paint_unionpaint_layers)**

See [PAINT_UNION.PAINT_LAYERS](#field-paint_unionpaint_layers).

### -field PAINT_UNION.PAINT_SOLID_GLYPH

Valid for paint elements of type [DWRITE_PAINT_TYPE_SOLID_GLYPH](./ne-dwrite_3-dwrite_paint_type.md). Specifies a glyph with a solid color fill. This paint element has no child elements.

This corresponds to a combination of two paint records in the OpenType COLR table: a *PaintGlyph* record, which references either a *PaintSolid* or *PaintVarSolid* record. Or it might correspond to a *Layer* record defined by COLR version 0.

### -field PAINT_UNION.PAINT_SOLID_GLYPH.glyphIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Glyph index defining the shape to be filled.

### -field PAINT_UNION.PAINT_SOLID_GLYPH.color

Type: **[DWRITE_PAINT_COLOR](./ns-dwrite_3-dwrite_paint_color.md)**

Glyph color used to fill the glyph shape.

### -field PAINT_UNION.solidGlyph

Type: **[PAINT_UNION.PAINT_SOLID_GLYPH](#field-paint_unionpaint_solid_glyph)**

See [PAINT_UNION.PAINT_SOLID_GLYPH](#field-paint_unionpaint_solid_glyph).

### -field PAINT_UNION.solid

Type: **[DWRITE_PAINT_COLOR](./ns-dwrite_3-dwrite_paint_color.md)**

Valid for paint elements of type [DWRITE_PAINT_TYPE_SOLID](./ne-dwrite_3-dwrite_paint_type.md). Specifies a solid color used to fill the current shape or clip. This paint element has no child elements.

This corresponds to a *PaintSolid* or *PaintVarSolid* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT

Valid for paint elements of type [DWRITE_PAINT_TYPE_LINEAR_GRADIENT](./ne-dwrite_3-dwrite_paint_type.md). Specifies a linear gradient used to fill the current shape or clip. This paint element has no child elements.

This corresponds to a *PaintLinearGradient* or *PaintVarLinearGradient* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.extendMode

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

A [D2D1_EXTEND_MODE](/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode) value specifying how colors outside the interval are defined.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.gradientStopCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of gradient stops. Use the [IDWritePaintReader::GetGradientStops](./nf-dwrite_3-idwritepaintreader-getgradientstops.md) method to get the gradient stops.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.x0

Type: **float**

X coordinate of the start point of the color line.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.y0

Type: **float**

Y coordinate of the start point of the color line.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.x1

Type: **float**

X coordinate of the end point of the color line.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.y1

Type: **float**

Y coordinate of the end point of the color line.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.x2

Type: **float**

X coordinate of the rotation point of the color line.

### -field PAINT_UNION.PAINT_LINEAR_GRADIENT.y2

Type: **float**

Y coordinate of the rotation point of the color line.

### -field PAINT_UNION.linearGradient

Type: **[PAINT_UNION.PAINT_LINEAR_GRADIENT](#field-paint_unionpaint_linear_gradient)**

See [PAINT_UNION.PAINT_LINEAR_GRADIENT](#field-paint_unionpaint_linear_gradient).

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT

Valid for paint elements of type [DWRITE_PAINT_TYPE_RADIAL_GRADIENT](./ne-dwrite_3-dwrite_paint_type.md). Specifies a radial gradient used to fill the current shape or clip. This paint element has no child elements.

This corresponds to a *PaintRadialGradient* or *PaintVarRadialGradient* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.extendMode

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

A [D2D1_EXTEND_MODE](/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode) value specifying how colors outside the interval are defined.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.gradientStopCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of gradient stops. Use the [IDWritePaintReader::GetGradientStops](./nf-dwrite_3-idwritepaintreader-getgradientstops.md) method to get the gradient stops.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.x0

Type: **float**

Center X coordinate of the start circle.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.y0

Type: **float**

Center Y coordinate of the start circle.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.radius0

Type: **float**

Radius of the start circle.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.x1

Type: **float**

Center X coordinate of the end circle.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.y1

Type: **float**

Center Y coordinate of the end circle.

### -field PAINT_UNION.PAINT_RADIAL_GRADIENT.radius1

Type: **float**

Radius of the end circle.

### -field PAINT_UNION.radialGradient

Type: **[PAINT_UNION.PAINT_RADIAL_GRADIENT](#field-paint_unionpaint_radial_gradient)**

See [PAINT_UNION.PAINT_RADIAL_GRADIENT](#field-paint_unionpaint_radial_gradient).

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT

Valid for paint elements of type [DWRITE_PAINT_TYPE_SWEEP_GRADIENT](./ne-dwrite_3-dwrite_paint_type.md). Specifies a sweep gradient used to fill the current shape or clip. This paint element has no child elements.

This corresponds to a *PaintSweepGradient* or *PaintVarSweepGradient* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.extendMode

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

A [D2D1_EXTEND_MODE](/windows/win32/api/d2d1/ne-d2d1-d2d1_extend_mode) value specifying how colors outside the interval are defined.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.gradientStopCount

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Number of gradient stops. Use the [IDWritePaintReader::GetGradientStops](./nf-dwrite_3-idwritepaintreader-getgradientstops.md) method to get the gradient stops.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.centerX

Type: **float**

Center X coordinate.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.centerY

Type: **float**

Center Y coordinate.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.startAngle

Type: **float**

Start of the angular range of the gradient, measured in counter-clockwise degrees from the direction of the positive x axis.

### -field PAINT_UNION.PAINT_SWEEP_GRADIENT.endAngle

Type: **float**

End of the angular range of the gradient, measured in counter-clockwise degrees from the direction of the positive x axis.

### -field PAINT_UNION.sweepGradient

Type: **[PAINT_UNION.PAINT_SWEEP_GRADIENT](#field-paint_unionpaint_sweep_gradient)**

See [PAINT_UNION.PAINT_SWEEP_GRADIENT](#field-paint_unionpaint_sweep_gradient).

### -field PAINT_UNION.PAINT_GLYPH

Valid for paint elements of type [DWRITE_PAINT_TYPE_GLYPH](./ne-dwrite_3-dwrite_paint_type.md). Specifies a glyph shape to be filled or, equivalently, a clip region. This paint element has one child element.

The child paint element defines how the glyph shape is filled. The child element can be a single paint element, such as a linear gradient. Or the child element can be the root of a visual tree to be rendered with the glyph shape as a clip region. This corresponds to a *PaintGlyph* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_GLYPH.glyphIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Glyph index of the glyph that defines the shape to be filled.

### -field PAINT_UNION.glyph

Type: **[PAINT_UNION.PAINT_GLYPH](#field-paint_unionpaint_glyph)**

See [PAINT_UNION.PAINT_GLYPH](#field-paint_unionpaint_glyph).

### -field PAINT_UNION.PAINT_COLOR_GLYPH

Valid for paint elements of type [DWRITE_PAINT_TYPE_COLOR_GLYPH](./ne-dwrite_3-dwrite_paint_type.md). Specifies another color glyph, used as a reusable component. This paint element has one child element, which is the root paint element of the specified color glyph.

This corresponds to a *PaintColorGlyph* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_COLOR_GLYPH.glyphIndex

Type: **[UINT32](/windows/win32/winprog/windows-data-types)**

Glyph index of the referenced color glyph.

### -field PAINT_UNION.PAINT_COLOR_GLYPH.clipBox

Type: **[D2D_RECT_F](/windows/win32/api/dcommon/ns-dcommon-d2d_rect_f)**

Clip box of the referenced color glyph, in ems. If the color glyph doesn't specify a clip box, then this is an empty rectangle. If it isn't an empty rectangle, then the client is required to clip the child content to this box.

### -field PAINT_UNION.colorGlyph

Type: **[PAINT_UNION.PAINT_COLOR_GLYPH](#field-paint_unionpaint_color_glyph)**

See [PAINT_UNION.PAINT_COLOR_GLYPH](#field-paint_unionpaint_color_glyph).

### -field PAINT_UNION.transform

Type: **[DWRITE_MATRIX](/windows/win32/api/dwrite/ns-dwrite-dwrite_matrix)**

Valid for paint elements of type [DWRITE_PAINT_TYPE_TRANSFORM](./ne-dwrite_3-dwrite_paint_type.md). Specifies an affine transform to be applied to child content. This paint element has one child element, which is the transformed content.

This corresponds to paint formats 12 through 31 in the OpenType COLR table.

### -field PAINT_UNION.PAINT_COMPOSITE

Valid for paint elements of type [DWRITE_PAINT_TYPE_COMPOSITE](./ne-dwrite_3-dwrite_paint_type.md). Combines the two child paint elements using the specified compositing or blending mode. This paint element has two child elements. The first child is the paint source. The second child is the paint destination (or backdrop).

This corresponds to a *PaintComposite* record in the OpenType COLR table.

### -field PAINT_UNION.PAINT_COMPOSITE.mode

Type: **[DWRITE_COLOR_COMPOSITE_MODE](./ne-dwrite_3-dwrite_color_composite_mode.md)**

Specifies the compositing or blending mode.

### -field PAINT_UNION.composite

Type: **[PAINT_UNION.PAINT_COMPOSITE](#field-paint_unionpaint_composite)**

See [PAINT_UNION.PAINT_COMPOSITE](#field-paint_unionpaint_composite).

### -field paint

Type: **[PAINT_UNION](#field-paint_union)**

See [PAINT_UNION](#field-paint_union).

## -remarks

## -see-also
